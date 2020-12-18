using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using PTum.Data;
using PTum.Models;

namespace Ptum.Controllers
{
    public class ProductController : Controller
    {
        private readonly PTumContext _context;
        public ProductController(PTumContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tb_mst_product.ToListAsync());
        }

        public IActionResult Excel()
        {

            var fileName = $"Template_MstProd.xlsx";
            var filepath = $"wwwroot/excel/_master/{fileName}";

            byte[] fileBytes = System.IO.File.ReadAllBytes(filepath);
            return File(fileBytes, "application/x-msdownload", fileName); 

        }
        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tb_mst_product = await _context.Tb_mst_product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tb_mst_product == null)
            {
                return NotFound();
            }

            return View(tb_mst_product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,prd_code,prd_name,prd_img,prd_category,prd_cate_img,prd_type,prd_model,prd_cpt_name,prd_fixasset_name,prd_serial_num,prd_regis_datetime,prd_regis_name,prd_last_uptime,prd_last_upname,prd_status")] Tb_mst_product tb_mst_product, List<IFormFile> files)
        {
            var time = DateTime.Now.ToString("yyyyMMddHHmmss");
            long size = files.Sum(f => f.Length);
            string filePath = null;

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    filePath = Path.Combine("./wwwroot/excel/mstprod/", $"MstProduct_{time}.xlsx");
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
                            _context.Add(new Tb_mst_product
                            {
                                prd_category = worksheet.Cells[row, 2].Value.ToString().Trim(),
                                prd_code = worksheet.Cells[row, 3].Value.ToString().Trim(),
                                prd_type = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                prd_model = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                prd_cpt_name = worksheet.Cells[row, 5].Value.ToString().Trim(),
                                prd_fixasset_name = worksheet.Cells[row, 6].Value.ToString().Trim(),
                                prd_serial_num = worksheet.Cells[row, 7].Value.ToString().Trim(),
                            });
                            await _context.SaveChangesAsync();
                        }
                    }
                }
            }

            // return Ok(new { count = files.Count, size });
            return RedirectToAction(nameof(Index)); 
        }
        // public async Task<IActionResult> Api()
        // {
        //     return Ok(new { count = 600 });
        // }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tb_mst_product = await _context.Tb_mst_product.FindAsync(id);
            if (tb_mst_product == null)
            {
                return NotFound();
            }
            return View(tb_mst_product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,prd_code,prd_name,prd_img,prd_category,prd_cate_img,prd_type,prd_model,prd_cpt_name,prd_fixasset_name,prd_serial_num,prd_regis_datetime,prd_regis_name,prd_last_uptime,prd_last_upname,prd_status")] Tb_mst_product tb_mst_product)
        {
            if (id != tb_mst_product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tb_mst_product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tb_mst_productExists(tb_mst_product.Id))
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
            return View(tb_mst_product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tb_mst_product = await _context.Tb_mst_product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tb_mst_product == null)
            {
                return NotFound();
            }

            return View(tb_mst_product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tb_mst_product = await _context.Tb_mst_product.FindAsync(id);
            _context.Tb_mst_product.Remove(tb_mst_product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tb_mst_productExists(int id)
        {
            return _context.Tb_mst_product.Any(e => e.Id == id);
        }
    }
}