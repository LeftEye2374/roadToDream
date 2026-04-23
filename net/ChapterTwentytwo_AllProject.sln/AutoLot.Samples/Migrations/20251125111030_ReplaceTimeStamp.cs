using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.Samples.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceTimeStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Radios_CarId",
                table: "Radios");

            migrationBuilder.CreateIndex(
                name: "IX_Radios_CarId",
                table: "Radios",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Radios_CarId",
                table: "Radios");

            migrationBuilder.CreateIndex(
                name: "IX_Radios_CarId",
                table: "Radios",
                column: "CarId",
                unique: true);
        }
    }
}
