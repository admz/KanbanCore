using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KbcList.Models
{
    public class AppIdentityDbContext : IdentityDbContext<User> 
    {       
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)  
            : base(options)
        { 

        }    
    }
}
