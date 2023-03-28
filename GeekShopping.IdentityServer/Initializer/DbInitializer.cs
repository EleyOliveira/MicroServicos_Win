using GeekShopping.IdentityServer.Model;
using GeekShopping.IdentityServer.Model.Context;
using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IdentityServer.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly MySQLContext _context;
        private readonly UserManager<ApplicationUser> _user;
        private readonly RoleManager<ApplicationUser> _role;

        public DbInitializer(MySQLContext context, UserManager<ApplicationUser> user, RoleManager<ApplicationUser> role)
        {
            _context = context;
            _user = user;
            _role = role;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
