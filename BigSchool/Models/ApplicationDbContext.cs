using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Course> Courses { set; get; }
            public DbSet<Category> Categories { set; get; }
            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
    
}