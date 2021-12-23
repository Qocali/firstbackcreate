using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace initialback.Migrations
{
    public partial class createFlorishType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlorishType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true,defaultValue:DateTime.UtcNow.AddHours(4))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlorishType", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlorishType");
        }
    }
}
