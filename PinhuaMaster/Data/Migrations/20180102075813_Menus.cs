using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Migrations
{
    public partial class Menus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(maxLength: 50, nullable: false),
                    IndexCode = table.Column<int>(nullable: false),
                    MenuType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    ParentId = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Url = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
