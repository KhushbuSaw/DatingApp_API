using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatingApp_Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
                
        }
        public DbSet<AppUserEntity> AppUser { get; set; }
    }
}
