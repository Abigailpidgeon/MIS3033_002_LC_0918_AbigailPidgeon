using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS3033_002_LC_0918_AbigailPidgeon.Migrations
{
    /// <inheritdoc />
    public partial class creategradedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StugradesTbl",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    grade = table.Column<double>(type: "REAL", nullable: false),
                    lettergrade = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StugradesTbl", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StugradesTbl");
        }
    }
}
