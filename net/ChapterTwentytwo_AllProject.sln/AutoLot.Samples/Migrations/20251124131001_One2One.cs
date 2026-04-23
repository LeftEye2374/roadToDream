using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLot.Samples.Migrations
{
    /// <inheritdoc />
    public partial class One2One : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radio_Cars_CarId",
                table: "Radio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Radio",
                table: "Radio");

            migrationBuilder.RenameTable(
                name: "Radio",
                newName: "Radios");

            migrationBuilder.RenameIndex(
                name: "IX_Radio_CarId",
                table: "Radios",
                newName: "IX_Radios_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Radios",
                table: "Radios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Radios_Cars_CarId",
                table: "Radios",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radios_Cars_CarId",
                table: "Radios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Radios",
                table: "Radios");

            migrationBuilder.RenameTable(
                name: "Radios",
                newName: "Radio");

            migrationBuilder.RenameIndex(
                name: "IX_Radios_CarId",
                table: "Radio",
                newName: "IX_Radio_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Radio",
                table: "Radio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Radio_Cars_CarId",
                table: "Radio",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
