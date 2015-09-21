using Microsoft.AspNet.Identity.EntityFramework;
using MSPP.Models;
using System;
using Microsoft.Data.Entity;
using Microsoft.Framework.DependencyInjection;

namespace MSPP.Controllers.Tool
{
    public class CustomDefine
    {
        public static string APPEND_PASSWORD = "@Nuaa123";

        public static async void InitialRulesData(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            if (context.Database.AsRelational().Exists())
            {
                if (!(await context.Roles.AnyAsync()))
                {
                    IdentityRole admin = new IdentityRole();
                    admin.Name = "Admin";
                    IdentityRole deAdmin = new IdentityRole();
                    deAdmin.Name = "DeAdmin";
                    IdentityRole account = new IdentityRole();
                    account.Name = "Account";
                    IdentityRole student = new IdentityRole();
                    student.Name = "Student";

                    context.Roles.Add(admin);
                    context.Roles.Add(deAdmin);
                    context.Roles.Add(account);
                    context.Roles.Add(student);

                    context.SaveChanges();

                }
                if (!(await context.UserModels.AnyAsync()))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        UserModels um = new UserModels();
                        um.Name = i.ToString();
                        context.UserModels.Add(um);
                    }

                    context.SaveChanges();
                }

                if (!(await context.ProjectModels.AnyAsync()))
                {
                    for (int i = 1; i < 6; i++)
                    {
                        ProjectModels pm = new ProjectModels();
                        pm.Name = i.ToString();
                        pm.Content = i.ToString();
                        pm.Account = 0;

                        context.ProjectModels.Add(pm);
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}
