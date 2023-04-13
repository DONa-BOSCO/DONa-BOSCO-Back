using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_users_t_user_rols_IdRol",
                table: "t_users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_user_rols",
                table: "t_user_rols");

            migrationBuilder.RenameTable(
                name: "t_user_rols",
                newName: "t_userRol");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_userRol",
                table: "t_userRol",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_t_users_t_userRol_IdRol",
                table: "t_users",
                column: "IdRol",
                principalTable: "t_userRol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_users_t_userRol_IdRol",
                table: "t_users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_userRol",
                table: "t_userRol");

            migrationBuilder.RenameTable(
                name: "t_userRol",
                newName: "t_user_rols");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_user_rols",
                table: "t_user_rols",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_t_users_t_user_rols_IdRol",
                table: "t_users",
                column: "IdRol",
                principalTable: "t_user_rols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
