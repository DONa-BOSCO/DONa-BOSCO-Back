using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_endpoint_authorizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HTTPMethodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_endpoint_authorizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileExtension = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPhotoFile = table.Column<int>(type: "int", nullable: false),
                    IdWeb = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_userRol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_userRol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_orders_t_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "t_products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_rols_authorizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdAuthorization = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_rols_authorizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_rols_authorizations_t_endpoint_authorizations_IdAuthorization",
                        column: x => x.IdAuthorization,
                        principalTable: "t_endpoint_authorizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_rols_authorizations_t_userRol_IdRol",
                        column: x => x.IdRol,
                        principalTable: "t_userRol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_orders_ProductId",
                table: "t_orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_t_rols_authorizations_IdAuthorization",
                table: "t_rols_authorizations",
                column: "IdAuthorization");

            migrationBuilder.CreateIndex(
                name: "IX_t_rols_authorizations_IdRol",
                table: "t_rols_authorizations",
                column: "IdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_files");

            migrationBuilder.DropTable(
                name: "t_orders");

            migrationBuilder.DropTable(
                name: "t_rols_authorizations");

            migrationBuilder.DropTable(
                name: "t_users");

            migrationBuilder.DropTable(
                name: "t_products");

            migrationBuilder.DropTable(
                name: "t_endpoint_authorizations");

            migrationBuilder.DropTable(
                name: "t_userRol");
        }
    }
}
