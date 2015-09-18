using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Framework.OptionsModel;

namespace MSM.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TaskAndUser>(entity =>
            {
                entity.Reference<UserModels>(d => d.User).InverseCollection(p => p.TaskAndUsers).ForeignKey(d => d.UserId);
                entity.Reference<TaskModels>(d => d.Task).InverseCollection(p => p.TaskAndUsers).ForeignKey(d => d.TaskId);
            });
            //builder.Entity<TaskAndUser>().Key(x => new { x.UserId, x.TaskId });
            builder.Entity<FinanceModels>(entity =>
            {
                entity.Reference<UserModels>(d => d.UserOpt).InverseCollection(p => p.FinanceOpt).ForeignKey(d => d.Operator);
                entity.Reference<UserModels>(d => d.UserPay).InverseCollection(p => p.FinancePay).ForeignKey(d => d.Payer);
                entity.Reference<ProjectModels>(d => d.Project).InverseCollection(p => p.Finances).ForeignKey(d => d.ProjectId);
            });
            builder.Entity<NoticeModels>(entity =>
            {
                entity.Reference<UserModels>(d => d.User).InverseCollection(p => p.NoticePub).ForeignKey(d => d.Publisher);
            });
            builder.Entity<RuleModels>(entity =>
            {
                entity.Reference<UserModels>(d => d.User).InverseCollection(p => p.RulePub).ForeignKey(d => d.Publisher);
            });
            builder.Entity<ShareModels>(entity =>
            {
                entity.Reference<UserModels>(d => d.User).InverseCollection(p => p.SharePub).ForeignKey(d => d.Publisher);
            });
            builder.Entity<TaskModels>(entity =>
            {
                entity.Reference<UserModels>(d => d.User).InverseCollection(p => p.TaskManager).ForeignKey(d => d.Manager);
                entity.Reference<ProjectModels>(d => d.Project).InverseCollection(p => p.Tasks).ForeignKey(d => d.ProjectId);
            });

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
