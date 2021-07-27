using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PTum.Data;
using PTum.Models;

namespace PTum.Controllers
{
    public class UserController : Controller
    {
        private readonly LoginContext _context;
         private readonly IConfiguration _config;

        public UserController(LoginContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            var tbUser = await _context.tbUser
                .Where(m => m.project_id == Int16.Parse(_config["MyProject:id"]))
                .ToListAsync();
            if (tbUser == null)
            {
                return NotFound();
            }

            return View(tbUser);
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUser = await _context.tbUser
                .FirstOrDefaultAsync(m => m.id == id);
            if (tbUser == null)
            {
                return NotFound();
            }

            return View(tbUser);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,username,password,email,tell,det,div,det_code,div_code,name,last_name,full_name,emp_code,position,project_id,status")] tbUser tbUser)
        {
            if (ModelState.IsValid)
            {
                // _context.Add(tbUser);
                _context.Add(new tbUser
                    {
                        username = tbUser.username,
                        password = tbUser.password,
                        det = tbUser.det,
                        det_code = tbUser.det_code,
                        name = tbUser.name,
                        last_name = tbUser.last_name,
                        emp_code = tbUser.emp_code,
                        position = "1",
                        project_id = Int16.Parse(_config["MyProject:id"])
                    });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbUser);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUser = await _context.tbUser.FindAsync(id);
            if (tbUser == null)
            {
                return NotFound();
            }
            return View(tbUser);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,username,password,email,tell,det,div,det_code,div_code,name,last_name,full_name,emp_code,position,status")] tbUser tbUser)
        {
            if (id != tbUser.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tbUser.project_id = Int16.Parse(_config["MyProject:id"]);
                    _context.Update(tbUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tbUserExists(tbUser.id))
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
            return View(tbUser);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUser = await _context.tbUser
                .FirstOrDefaultAsync(m => m.id == id);
            if (tbUser == null)
            {
                return NotFound();
            }

            return View(tbUser);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbUser = await _context.tbUser.FindAsync(id);
            _context.tbUser.Remove(tbUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tbUserExists(int id)
        {
            return _context.tbUser.Any(e => e.id == id);
        }
    }
}
