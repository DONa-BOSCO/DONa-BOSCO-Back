using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PosterName",
                table: "t_products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserItemId",
                table: "t_products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_t_products_UserItemId",
                table: "t_products",
                column: "UserItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_products_t_users_UserItemId",
                table: "t_products",
                column: "UserItemId",
                principalTable: "t_users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_products_t_users_UserItemId",
                table: "t_products");

            migrationBuilder.DropIndex(
                name: "IX_t_products_UserItemId",
                table: "t_products");

            migrationBuilder.DropColumn(
                name: "PosterName",
                table: "t_products");

            migrationBuilder.DropColumn(
                name: "UserItemId",
                table: "t_products");
        }
    }
}
