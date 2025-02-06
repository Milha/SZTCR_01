using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SZTCR_01.Migrations
{
    /// <inheritdoc />
    public partial class AddDobavljacDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NazivDobavljaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresaDobavljaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailDobavljaca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dobavljaci");
        }
    }
}
