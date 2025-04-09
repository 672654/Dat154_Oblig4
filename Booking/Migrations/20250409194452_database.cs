using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CheckedIn",
                table: "Room",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CheckedOut",
                table: "Room",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckedIn",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CheckedOut",
                table: "Room");
        }
    }
}
