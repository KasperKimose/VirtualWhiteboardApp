using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualWhiteboardAPI.Migrations
{
    public partial class addidtoposttowhiteboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Whiteboards_WhiteboardId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_WhiteboardId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "WhiteboardId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostedOn_Id",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostedOn_Id",
                table: "Posts",
                column: "PostedOn_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Whiteboards_PostedOn_Id",
                table: "Posts",
                column: "PostedOn_Id",
                principalTable: "Whiteboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Whiteboards_PostedOn_Id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostedOn_Id",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostedOn_Id",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "WhiteboardId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_WhiteboardId",
                table: "Posts",
                column: "WhiteboardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Whiteboards_WhiteboardId",
                table: "Posts",
                column: "WhiteboardId",
                principalTable: "Whiteboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
