using Microsoft.EntityFrameworkCore;
using PTum.Models;

namespace PTum.Data
{
    public class LoginContext : DbContext
    {
        public LoginContext (DbContextOptions<LoginContext> options)
            : base(options)
        {
        }
        public DbSet<PTum.Models.tbUser> tbUser { get; set; }


    }
}