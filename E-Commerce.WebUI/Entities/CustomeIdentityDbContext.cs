using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.WebUI.Entities
{
    public class CustomeIdentityDbContext:IdentityDbContext<CustomIdentityUser,CustomIdentityRole,string>
    {
        public CustomeIdentityDbContext(DbContextOptions<CustomeIdentityDbContext> options)
            :base(options)
        {

        }
    }
}
