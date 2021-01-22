using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style; 
using OfficeOpenXml.Table;
using PTum.Data;
using PTum.Models;
using Microsoft.AspNetCore.Http;

namespace Ptum.Controllers
{
    public class StockInController : Controller
    {
        private readonly PTumContext _context;

        public StockInController(PTumContext context)
        {
            _context = context;
        }

        // GET: StockIn
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tb_stock_in.ToListAsync());
        }

        public async Task<IActionResult> Excel()
        {

            var time = DateTime.Now.ToString("yyyyMMddHHmmss");
            var fileName = $"StockIN_{time}.xlsx";
            var filepath = $"wwwroot/excel/stockin/{fileName}";
            var originalFileName = $"Template_StockIN.xlsx";
            var originalFilePath = $"wwwroot/excel/_master/{originalFileName}";

            var tb_mst_product = await _context.Tb_mst_product.ToListAsync();

            using(var package = new ExcelPackage(new FileInfo(originalFilePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
        
                int recordIndex = 3; 
                
                foreach (var item in tb_mst_product) 
                { 
                    worksheet.Cells[recordIndex, 1].Value = item.Id; 
                    worksheet.Cells[recordIndex, 2].Value = (recordIndex-2).ToString(); 
                    worksheet.Cells[recordIndex, 3].Value = item.prd_category;
                    worksheet.Cells[recordIndex, 4].Value = item.prd_code; 
                    worksheet.Cells[recordIndex, 5].Value = item.prd_type; 
                    worksheet.Cells[recordIndex, 6].Value = item.prd_model; 
                    recordIndex++; 
                } 
                package.SaveAs(new FileInfo(filepath));
                package.Dispose();
            }  

            byte[] fileBytes = System.IO.File.ReadAllBytes(filepath);
            return File(fileBytes, "application/x-msdownload", fileName); 

        }

        // GET: StockIn/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tb_stock_in = await _context.Tb_stock_in
                .FirstOrDefaultAsync(m => m.id_in == id);
            if (tb_stock_in == null)
            {
                return NotFound();
            }

            return View(tb_stock_in);
        }

        // GET: StockIn/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockIn/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_in,prd_code,prd_inqty,in_status,in_datetime,in_name,in_last_uptime,in_last_upname")] Tb_stock_in tb_stock_in, List<IFormFile> files)
        {
            var time = DateTime.Now.ToString("yyyyMMddHHmmss");
            long size = files.Sum(f => f.Length);
            string filePath = null;

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    filePath = Path.Combine("./wwwroot/excel/stockin/", $"StockIn_{time}.xlsx");
                    Console.WriteLine(filePath);
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            if (ModelState.IsValid){
                if(System.IO.File.Exists(filePath)){
                    Console.WriteLine("File exists.");
                    using(var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;
                        for (int row = 3; row <= rowCount; row++){
                            if(worksheet.Cells[row, 4].Value!=null || worksheet.Cells[row, 10].Value.ToString().Trim()!=""){
                                _context.Add(new Tb_stock_in
                                {
                                    prd_code = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                    prd_inqty = int.Parse(worksheet.Cells[row, 10].Value.ToString().Trim()),
                                    in_datetime = DateTime.Now,
                                    in_name = HttpContext.Session.GetString("_Name"),
                                });
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
            }

            return Ok(new { success= true, count = files.Count, size });
            // return Ok(new { success= true });
            // return RedirectToAction(nameof(Index)); 
        }

        // GET: StockIn/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tb_stock_in = await _context.Tb_stock_in.FindAsync(id);
            if (tb_stock_in == null)
            {
                return NotFound();
            }
            return View(tb_stock_in);
        }

        // POST: StockIn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_in,prd_code,prd_inqty,in_status,in_datetime,in_name,in_last_uptime,in_last_upname")] Tb_stock_in tb_stock_in)
        {
            if (id != tb_stock_in.id_in)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tb_stock_in);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tb_stock_inExists(tb_stock_in.id_in))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tb_stock_in);
        }

        // GET: StockIn/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tb_stock_in = await _context.Tb_stock_in
                .FirstOrDefaultAsync(m => m.id_in == id);
            if (tb_stock_in == null)
            {
                return NotFound();
            }

            return View(tb_stock_in);
        }

        // POST: StockIn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tb_stock_in = await _context.Tb_stock_in.FindAsync(id);
            _context.Tb_stock_in.Remove(tb_stock_in);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tb_stock_inExists(int id)
        {
            return _context.Tb_stock_in.Any(e => e.id_in == id);
        }
    }
}
