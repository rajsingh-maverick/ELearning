using ELearning.Model.Poco;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DAL
{
       public class ApplicationUser : IdentityUser
        {
            
            public string EmailId { get; set; }
            public int Age { get; set; }
        }

        public class ELearningContext : IdentityDbContext<ApplicationUser>
        {          
            public ELearningContext()
                : base("ELearningConnection")
            {
            }
                public DbSet<Question> Questions { get; set; }
                public DbSet<Option> Options { get; set; }
                public DbSet<Subject> Subjects { get; set; }
            
        }
}
