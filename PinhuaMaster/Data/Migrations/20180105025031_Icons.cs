using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Migrations
{
    public partial class Icons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ClassName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    SourceType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Icons");
        }
    }
}
