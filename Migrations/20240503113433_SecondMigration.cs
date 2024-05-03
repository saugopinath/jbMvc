using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jbMvc.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "mobile_no",
                table: "AspNetUsers",
                type: "char(10)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mobile_no",
                table: "AspNetUsers");
        }
    }
}
