using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PTum.Data;
using Ptum.Models;

namespace Ptum.Controllers
{
    public class HomeController : Controller
    {
        private readonly PTumContext _context;

        public HomeController(PTumContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Balance_V.ToListAsync());
        }
    }
}
