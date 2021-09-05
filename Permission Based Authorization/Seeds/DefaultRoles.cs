using Microsoft.AspNetCore.Identity;
using Permission_Based_Authorization.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Permission_Based_Authorization.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> rolemanager)
        {
            if (!rolemanager.Roles.Any())
            {
                await rolemanager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
                await rolemanager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
                await rolemanager.CreateAsync(new IdentityRole(Roles.Basic.ToString()));
            }
        }
    }
}
