using Marketplace.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marketplace
{
    public class AppDbContext : IdentityDbContext<IdeUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        
        }
        

    }
}
