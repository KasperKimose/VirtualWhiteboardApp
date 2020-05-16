using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualWhiteboardAPI.Migrations
{
    public partial class UpdatesUserToHoldPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_PostedById",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostedById",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostedById",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostedBy_Id",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostedBy_Id",
                table: "Posts",
                column: "PostedBy_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_PostedBy_Id",
                table: "Posts",
                column: "PostedBy_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_PostedBy_Id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostedBy_Id",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostedBy_Id",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostedById",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostedById",
                table: "Posts",
                column: "PostedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_PostedById",
                table: "Posts",
                column: "PostedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
