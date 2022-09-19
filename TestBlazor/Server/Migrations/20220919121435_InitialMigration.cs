using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBlazor.Server.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Cellnumber", "Email", "Username" },
                values: new object[] { new Guid("1c4f3086-8f8f-44f5-90f2-1e4b7b46fae8"), "7896541230", "cf@code.com", "CodeFather" });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Cellnumber", "Email", "Username" },
                values: new object[] { new Guid("802ad524-90c0-4699-9c53-a117d4c48288"), "997", "king@code.com", "KingCoder" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Developers");
        }
    }
}
