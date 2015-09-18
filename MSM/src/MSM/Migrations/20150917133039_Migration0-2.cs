using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace MSM.Migrations
{
    public partial class Migration02 : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.DropPrimaryKey(name: "PK_TaskAndUser", table: "TaskAndUser");
            migration.AddColumn(
                name: "Id",
                table: "TaskAndUser",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:ValueGeneration", "Identity");
            migration.AddPrimaryKey(
                name: "PK_TaskAndUser",
                table: "TaskAndUser",
                column: "Id");
            migration.AddForeignKey(
                name: "FK_TaskAndUser_UserModels_UserId",
                table: "TaskAndUser",
                column: "UserId",
                referencedTable: "UserModels",
                referencedColumn: "Id");
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropPrimaryKey(name: "PK_TaskAndUser", table: "TaskAndUser");
            migration.DropForeignKey(name: "FK_TaskAndUser_UserModels_UserId", table: "TaskAndUser");
            migration.DropColumn(name: "Id", table: "TaskAndUser");
            migration.AddPrimaryKey(
                name: "PK_TaskAndUser",
                table: "TaskAndUser",
                columns: new[] { "UserId", "TaskId" });
        }
    }
}
