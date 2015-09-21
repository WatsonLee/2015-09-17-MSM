using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using MSPP.Models;

namespace MSPP.Migrations
{
    [ContextType(typeof(ApplicationDbContext))]
    partial class migration0
    {
        public override string Id
        {
            get { return "20150921061606_migration0"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta5-13549"; }
        }
        
        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("SqlServer:ValueGeneration", "Identity");
            
            builder.Entity("MSPP.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .GenerateValueOnAdd();
                    
                    b.Property<int>("AccessFailedCount");
                    
                    b.Property<string>("ConcurrencyStamp")
                        .ConcurrencyToken();
                    
                    b.Property<string>("Email");
                    
                    b.Property<bool>("EmailConfirmed");
                    
                    b.Property<bool>("LockoutEnabled");
                    
                    b.Property<DateTimeOffset?>("LockoutEnd");
                    
                    b.Property<string>("NormalizedEmail");
                    
                    b.Property<string>("NormalizedUserName");
                    
                    b.Property<string>("PasswordHash");
                    
                    b.Property<string>("PhoneNumber");
                    
                    b.Property<bool>("PhoneNumberConfirmed");
                    
                    b.Property<string>("SecurityStamp");
                    
                    b.Property<bool>("TwoFactorEnabled");
                    
                    b.Property<string>("UserName");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetUsers");
                });
            
            builder.Entity("MSPP.Models.FinanceKind", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Content");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "FinanceKind");
                });
            
            builder.Entity("MSPP.Models.FinanceModels", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<DateTime>("ApplyDate");
                    
                    b.Property<int>("Direction");
                    
                    b.Property<int>("KindId");
                    
                    b.Property<DateTime>("OperateDate");
                    
                    b.Property<int>("Operator");
                    
                    b.Property<int>("Payer");
                    
                    b.Property<int>("ProjectId");
                    
                    b.Property<string>("Receiver");
                    
                    b.Property<int>("State");
                    
                    b.Property<decimal>("Value");
                    
                    b.Key("Id");
                });
            
            builder.Entity("MSPP.Models.NoticeModels", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Content");
                    
                    b.Property<string>("FilePath");
                    
                    b.Property<DateTime>("PublishTime");
                    
                    b.Property<int>("Publisher");
                    
                    b.Property<DateTime>("SubmitTime");
                    
                    b.Key("Id");
                });
            
            builder.Entity("MSPP.Models.ProjectModels", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<decimal>("Account");
                    
                    b.Property<string>("Content");
                    
                    b.Property<DateTime>("Date");
                    
                    b.Property<string>("Name");
                    
                    b.Key("Id");
                });
            
            builder.Entity("MSPP.Models.RuleModels", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Content");
                    
                    b.Property<string>("FilePath");
                    
                    b.Property<int>("Publisher");
                    
                    b.Property<DateTime>("SubmitTime");
                    
                    b.Key("Id");
                });
            
            builder.Entity("MSPP.Models.ShareModels", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Content");
                    
                    b.Property<string>("FilePath");
                    
                    b.Property<int>("Publisher");
                    
                    b.Property<DateTime>("SubmitTime");
                    
                    b.Key("Id");
                });
            
            builder.Entity("MSPP.Models.TaskAndUser", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<int>("TaskId");
                    
                    b.Property<int>("UserId");
                    
                    b.Key("Id");
                });
            
            builder.Entity("MSPP.Models.TaskModels", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<DateTime>("ApplyDate");
                    
                    b.Property<decimal>("Budget");
                    
                    b.Property<int>("Creator");
                    
                    b.Property<DateTime>("FinishDate");
                    
                    b.Property<int>("Manager");
                    
                    b.Property<int>("ProjectId");
                    
                    b.Property<int>("State");
                    
                    b.Property<string>("Title");
                    
                    b.Key("Id");
                });
            
            builder.Entity("MSPP.Models.UserModels", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<DateTime>("Birthday");
                    
                    b.Property<string>("Description");
                    
                    b.Property<string>("Education");
                    
                    b.Property<string>("Email");
                    
                    b.Property<DateTime>("GraduateTime");
                    
                    b.Property<DateTime>("JoinTime");
                    
                    b.Property<string>("Major");
                    
                    b.Property<int>("Marry");
                    
                    b.Property<string>("Name");
                    
                    b.Property<string>("Native");
                    
                    b.Property<string>("Phone");
                    
                    b.Property<int>("State");
                    
                    b.Property<string>("University");
                    
                    b.Key("Id");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .GenerateValueOnAdd();
                    
                    b.Property<string>("ConcurrencyStamp")
                        .ConcurrencyToken();
                    
                    b.Property<string>("Name");
                    
                    b.Property<string>("NormalizedName");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetRoles");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("ClaimType");
                    
                    b.Property<string>("ClaimValue");
                    
                    b.Property<string>("RoleId");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetRoleClaims");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("ClaimType");
                    
                    b.Property<string>("ClaimValue");
                    
                    b.Property<string>("UserId");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetUserClaims");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .GenerateValueOnAdd();
                    
                    b.Property<string>("ProviderKey")
                        .GenerateValueOnAdd();
                    
                    b.Property<string>("ProviderDisplayName");
                    
                    b.Property<string>("UserId");
                    
                    b.Key("LoginProvider", "ProviderKey");
                    
                    b.Annotation("Relational:TableName", "AspNetUserLogins");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");
                    
                    b.Property<string>("RoleId");
                    
                    b.Key("UserId", "RoleId");
                    
                    b.Annotation("Relational:TableName", "AspNetUserRoles");
                });
            
            builder.Entity("MSPP.Models.FinanceModels", b =>
                {
                    b.Reference("MSPP.Models.FinanceKind")
                        .InverseCollection()
                        .ForeignKey("KindId");
                    
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("Operator");
                    
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("Payer");
                    
                    b.Reference("MSPP.Models.ProjectModels")
                        .InverseCollection()
                        .ForeignKey("ProjectId");
                });
            
            builder.Entity("MSPP.Models.NoticeModels", b =>
                {
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("Publisher");
                });
            
            builder.Entity("MSPP.Models.RuleModels", b =>
                {
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("Publisher");
                });
            
            builder.Entity("MSPP.Models.ShareModels", b =>
                {
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("Publisher");
                });
            
            builder.Entity("MSPP.Models.TaskAndUser", b =>
                {
                    b.Reference("MSPP.Models.TaskModels")
                        .InverseCollection()
                        .ForeignKey("TaskId");
                    
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("MSPP.Models.TaskModels", b =>
                {
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("Creator");
                    
                    b.Reference("MSPP.Models.UserModels")
                        .InverseCollection()
                        .ForeignKey("Manager");
                    
                    b.Reference("MSPP.Models.ProjectModels")
                        .InverseCollection()
                        .ForeignKey("ProjectId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Reference("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .InverseCollection()
                        .ForeignKey("RoleId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Reference("MSPP.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Reference("MSPP.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Reference("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .InverseCollection()
                        .ForeignKey("RoleId");
                    
                    b.Reference("MSPP.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
        }
    }
}
