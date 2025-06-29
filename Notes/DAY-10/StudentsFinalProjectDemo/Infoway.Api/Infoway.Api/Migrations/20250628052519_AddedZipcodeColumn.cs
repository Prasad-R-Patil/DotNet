using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infoway.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedZipcodeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "Customers");
        }
    }
}
