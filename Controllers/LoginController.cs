using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using PTum.Data;
using PTum.Models;

namespace Ptum.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginContext _context;
        public const string SessionUsername  = "_Name";
        public string SessionEmpNo { get; private set; } 
        public string SessionFirstname { get; private set; }
        public string SessionLastname { get; private set; }
        public LoginController(LoginContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Check([Bind("id,username,password,email,tell,det,div,det_code,div_code,name,last_name,full_name,emp_code,position,project_id,status")] tbUser tbUser)
        {
            var success = true;

            var user = await _context.tbUser
                .FirstOrDefaultAsync(
                    m => m.username == tbUser.username &&
                    m.password == tbUser.password
                );

            if (user == null){
                success = false;
            }
            else{
                HttpContext.Session.SetString(SessionUsername, user.username);
            }

            return Ok(new { 
                success=success,
                user
            });
        }  

        [Route("Logout")]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
