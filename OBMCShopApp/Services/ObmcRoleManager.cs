using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Models;

namespace OBMCShopApp.Services
{
    public class ObmcRoleManager
    {
        public static void AddRoles(RoleManager<ApplicationRole> roleManager)
        {
            Task.Run(async () =>
            {
                if (!await roleManager.Roles.AnyAsync())
                {
                    var roles = new List<ApplicationRole>
                    {
                        new ApplicationRole
                        {
                            Name = "Owner",
                            Id = Guid.NewGuid().ToString("D"),
                            Description = "Owner of the Business who can do anything admin can",
                            NormalizedName = "Business Owner",
                            ConcurrencyStamp =
                                $"{Guid.NewGuid().ToString("D")}-{DateTimeOffset.UtcNow.Ticks.ToString()}"
                        },
                        new ApplicationRole
                        {
                            Name = "Admin",
                            Id = Guid.NewGuid().ToString("D"),
                            Description = "Admin of the application",
                            NormalizedName = "Application Administrator",
                            ConcurrencyStamp =
                                $"{Guid.NewGuid().ToString("D")}-{DateTimeOffset.UtcNow.Ticks.ToString()}"
                        },
                        new ApplicationRole
                        {
                            Name = "SalesPerson",
                            Id = Guid.NewGuid().ToString("D"),
                            Description = "Shop Keeper",
                            NormalizedName = "Store Keeper and Sales Person",
                            ConcurrencyStamp =
                                $"{Guid.NewGuid().ToString("D")}-{DateTimeOffset.UtcNow.Ticks.ToString()}"
                        }
                    };

                    foreach (var role in roles)
                    {
                        await roleManager.CreateAsync(role).ConfigureAwait(false);
                    }
                }
            });
        }

    }
}