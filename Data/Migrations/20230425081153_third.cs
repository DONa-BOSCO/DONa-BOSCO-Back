using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "t_products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "t_products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_t_products_UserId1",
                table: "t_products",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_t_products_t_users_UserId1",
                table: "t_products",
                column: "UserId1",
                principalTable: "t_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_products_t_users_UserId1",
                table: "t_products");

            migrationBuilder.DropIndex(
                name: "IX_t_products_UserId1",
                table: "t_products");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "t_products");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "t_products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
