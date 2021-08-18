using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Migrations
{
    public partial class RolePages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RolePages",
                columns: table => new
                {
                    RoleId = table.Column<string>(nullable: false),
                    Page = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePages", x => new { x.RoleId, x.Page });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePages");
        }
    }
}
