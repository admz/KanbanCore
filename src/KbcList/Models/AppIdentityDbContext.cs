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
