using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace MSM.Migrations
{
    public partial class Migration00 : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "NoticeModels",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    Content = table.Column(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column(type: "nvarchar(max)", nullable: true),
                    PublishTime = table.Column(type: "datetime2", nullable: false),
                    Publisher = table.Column(type: "int", nullable: false),
                    SubmitTime = table.Column(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeModels", x => x.Id);
                });
            migration.CreateTable(
                name: "ProjectModels",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    Account = table.Column(type: "decimal(18, 2)", nullable: false),
                    Content = table.Column(type: "nvarchar(max)", nullable: true),
                    Date = table.Column(type: "datetime2", nullable: false),
                    Name = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectModels", x => x.Id);
                });
            migration.CreateTable(
                name: "RuleModels",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    Content = table.Column(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column(type: "int", nullable: false),
                    SubmitTime = table.Column(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleModels", x => x.Id);
                });
            migration.CreateTable(
                name: "ShareModels",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    Content = table.Column(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column(type: "int", nullable: false),
                    SubmitTime = table.Column(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareModels", x => x.Id);
                });
            migration.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    Birthday = table.Column(type: "datetime2", nullable: false),
                    Description = table.Column(type: "nvarchar(max)", nullable: true),
                    Education = table.Column(type: "nvarchar(max)", nullable: true),
                    Email = table.Column(type: "nvarchar(max)", nullable: true),
                    GraduateTime = table.Column(type: "datetime2", nullable: false),
                    JoinTime = table.Column(type: "datetime2", nullable: false),
                    Major = table.Column(type: "nvarchar(max)", nullable: true),
                    Marry = table.Column(type: "int", nullable: false),
                    Name = table.Column(type: "nvarchar(max)", nullable: true),
                    Native = table.Column(type: "nvarchar(max)", nullable: true),
                    Password = table.Column(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column(type: "nvarchar(max)", nullable: true),
                    Role = table.Column(type: "int", nullable: false),
                    State = table.Column(type: "int", nullable: false),
                    University = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.Id);
                });
            migration.CreateTable(
                name: "FinanceModels",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    ApplyDate = table.Column(type: "datetime2", nullable: false),
                    Direction = table.Column(type: "int", nullable: false),
                    OperateDate = table.Column(type: "datetime2", nullable: false),
                    Operator = table.Column(type: "int", nullable: false),
                    Payer = table.Column(type: "int", nullable: false),
                    ProjectId = table.Column(type: "int", nullable: false),
                    Receiver = table.Column(type: "nvarchar(max)", nullable: true),
                    State = table.Column(type: "int", nullable: false),
                    Value = table.Column(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinanceModels_ProjectModels_ProjectId",
                        columns: x => x.ProjectId,
                        referencedTable: "ProjectModels",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "TaskModels",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    ApplyDate = table.Column(type: "datetime2", nullable: false),
                    Budget = table.Column(type: "decimal(18, 2)", nullable: false),
                    FinishDate = table.Column(type: "datetime2", nullable: false),
                    Manager = table.Column(type: "int", nullable: false),
                    ProjectId = table.Column(type: "int", nullable: false),
                    State = table.Column(type: "int", nullable: false),
                    Title = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskModels_ProjectModels_ProjectId",
                        columns: x => x.ProjectId,
                        referencedTable: "ProjectModels",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "TaskAndUser",
                columns: table => new
                {
                    UserId = table.Column(type: "int", nullable: false),
                    TaskId = table.Column(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAndUser", x => new { x.UserId, x.TaskId });
                    table.ForeignKey(
                        name: "FK_TaskAndUser_TaskModels_TaskId",
                        columns: x => x.TaskId,
                        referencedTable: "TaskModels",
                        referencedColumn: "Id");
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("FinanceModels");
            migration.DropTable("NoticeModels");
            migration.DropTable("ProjectModels");
            migration.DropTable("RuleModels");
            migration.DropTable("ShareModels");
            migration.DropTable("TaskAndUser");
            migration.DropTable("TaskModels");
            migration.DropTable("UserModels");
        }
    }
}
