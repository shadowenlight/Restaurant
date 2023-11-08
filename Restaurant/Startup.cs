using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Restaurant.Models;

[assembly: OwinStartupAttribute(typeof(Restaurant.Startup))]
namespace Restaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var RoleManager = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>
                (context));

            var UserManager = new UserManager<ApplicationUser>
                (new UserStore<ApplicationUser>
                (context));

            //Creating first Admin role and default admin user.
            if (!RoleManager.RoleExists("Admin"))
            {
                //Creating Admin role.
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                RoleManager.Create(role);

                //Creating Admin super user.
                var user = new ApplicationUser();
                user.UserName = "SuperAdmin";
                user.Email = "adminrestaurant@gmail.com";

                string userPDW = "123891998";
                var chkUser = UserManager.Create(user, userPDW);
                
                //Add created user to the admin role.
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                }
            }

            //Create Manager role.
            if (!RoleManager.RoleExists("Manager"))
            {
                //Creating Manager role.
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Manager";
                RoleManager.Create(role);
            }

            //Create Employee role.
            if (!RoleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                RoleManager.Create(role);
            }
        }
    }
}
