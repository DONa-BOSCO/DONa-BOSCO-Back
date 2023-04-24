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
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "t_products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_t_products_UserId",
                table: "t_products",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_products_t_users_UserId",
                table: "t_products",
                column: "UserId",
                principalTable: "t_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_products_t_users_UserId",
                table: "t_products");

            migrationBuilder.DropIndex(
                name: "IX_t_products_UserId",
                table: "t_products");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "t_products");
        }
    }
}
