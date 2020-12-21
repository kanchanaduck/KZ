using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTum.Data;
using PTum.Models;

namespace Ptum.Controllers
{
    public class StockOutController : Controller
    {
        private readonly PTumContext _context;

        public StockOutController(PTumContext context)
        {
            _context = context;
        }

        // GET: StockOut
        public async Task<IActionResult> Api()
        {
            // return Ok(await _context.Tb_stock_out.ToListAsync());
            return View();
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tb_stock_out.ToListAsync());
        }
    }
}
