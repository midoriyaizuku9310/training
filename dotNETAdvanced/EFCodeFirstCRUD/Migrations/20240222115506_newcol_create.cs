using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstCRUD.Migrations
{
    /// <inheritdoc />
    public partial class newcol_create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "country",
                table: "customers");
        }
    }
}
