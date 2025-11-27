using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tally.Data.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseMigrationV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_Locations_LocationId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_Rooms_RoomId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_CommonCatagories_CustomCatagoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Locations_LocationId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Containers_LocationId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Containers");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Containers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_Rooms_RoomId",
                table: "Containers",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_CommonCatagories_CustomCatagoryId",
                table: "Items",
                column: "CustomCatagoryId",
                principalTable: "CommonCatagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Locations_LocationId",
                table: "Rooms",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_Rooms_RoomId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_CommonCatagories_CustomCatagoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Locations_LocationId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Locations");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Containers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Containers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Containers_LocationId",
                table: "Containers",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_Locations_LocationId",
                table: "Containers",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_Rooms_RoomId",
                table: "Containers",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_CommonCatagories_CustomCatagoryId",
                table: "Items",
                column: "CustomCatagoryId",
                principalTable: "CommonCatagories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Locations_LocationId",
                table: "Rooms",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
