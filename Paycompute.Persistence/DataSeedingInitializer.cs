using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Persistence
{
      public static class DataSeedingInitializer
      {
            public static async Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager, 
                                                    RoleManager<IdentityRole> roleManager)
            {
                  string[] roles = { "Admin", "Manager", "Staff" };
                  foreach (var role in roles)
                  {
                        var roleExist = await roleManager.RoleExistsAsync(role);
                        if(!roleExist){
                              IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                        }
                  }

                  // Create Admin User
                  if(userManager.FindByEmailAsync("eyetanvir@gmail.com").Result == null )
                  {
                        IdentityUser user = new IdentityUser
                        {
                              UserName = "eyetanvir@gmail.com",
                              Email = "eyetanvir@gmail.com",
                        };
                        IdentityResult identityResult = userManager.CreateAsync(user, "Test123@").Result;
                        if (identityResult.Succeeded)
                        {
                              userManager.AddToRoleAsync(user, "Admin").Wait();
                        }
                  }
                  //Create Manager User
                  if (userManager.FindByEmailAsync("manager@gmail.com").Result == null)
                  {
                        IdentityUser user = new IdentityUser
                        {
                              UserName = "manager@gmail.com",
                              Email = "manager@gmail.com",
                        };
                        IdentityResult identityResult = userManager.CreateAsync(user, "Test123@").Result;
                        if (identityResult.Succeeded)
                        {
                              userManager.AddToRoleAsync(user, "Manager").Wait();
                        }
                  }
                  //Create Staff User
                  if (userManager.FindByEmailAsync("janedoe@gmail.com").Result == null)
                  {
                        IdentityUser user = new IdentityUser
                        {
                              UserName = "janedoe@gmail.com",
                              Email = "janedoe@gmail.com",
                        };
                        IdentityResult identityResult = userManager.CreateAsync(user, "Test123@").Result;
                        if (identityResult.Succeeded)
                        {
                              userManager.AddToRoleAsync(user, "Staff").Wait();
                        }
                  }
                  //Create a no role User
                  if (userManager.FindByEmailAsync("johndoe@gmail.com").Result == null)
                  {
                        IdentityUser user = new IdentityUser
                        {
                              UserName = "johndoe@gmail.com",
                              Email = "johndoe@gmail.com",
                        };
                        IdentityResult identityResult = userManager.CreateAsync(user, "Test123@").Result;
                      //No role Assigned to Mr John Doe
                  }
            }
      }
}
