using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace MSM.Migrations
{
    public partial class Migration01 : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.AddForeignKey(
                name: "FK_FinanceModels_UserModels_Operator",
                table: "FinanceModels",
                column: "Operator",
                referencedTable: "UserModels",
                referencedColumn: "Id");
            migration.AddForeignKey(
                name: "FK_FinanceModels_UserModels_Payer",
                table: "FinanceModels",
                column: "Payer",
                referencedTable: "UserModels",
                referencedColumn: "Id");
            migration.AddForeignKey(
                name: "FK_NoticeModels_UserModels_Publisher",
                table: "NoticeModels",
                column: "Publisher",
                referencedTable: "UserModels",
                referencedColumn: "Id");
            migration.AddForeignKey(
                name: "FK_RuleModels_UserModels_Publisher",
                table: "RuleModels",
                column: "Publisher",
                referencedTable: "UserModels",
                referencedColumn: "Id");
            migration.AddForeignKey(
                name: "FK_ShareModels_UserModels_Publisher",
                table: "ShareModels",
                column: "Publisher",
                referencedTable: "UserModels",
                referencedColumn: "Id");
            migration.AddForeignKey(
                name: "FK_TaskModels_UserModels_Manager",
                table: "TaskModels",
                column: "Manager",
                referencedTable: "UserModels",
                referencedColumn: "Id");
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropForeignKey(name: "FK_FinanceModels_UserModels_Operator", table: "FinanceModels");
            migration.DropForeignKey(name: "FK_FinanceModels_UserModels_Payer", table: "FinanceModels");
            migration.DropForeignKey(name: "FK_NoticeModels_UserModels_Publisher", table: "NoticeModels");
            migration.DropForeignKey(name: "FK_RuleModels_UserModels_Publisher", table: "RuleModels");
            migration.DropForeignKey(name: "FK_ShareModels_UserModels_Publisher", table: "ShareModels");
            migration.DropForeignKey(name: "FK_TaskModels_UserModels_Manager", table: "TaskModels");
        }
    }
}
