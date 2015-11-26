using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TokenBasedAuthentication.Repositories
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // Database.SetInitializer<AuthContext>(new DropCreateDatabaseAlways<AuthContext>());
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<AuthContext>(null);
        }
    }
}
