using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.data.migrations;

/// <inheritdoc />
public partial class initialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "ProductBrands",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProductBrands", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "ProductTypes",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProductTypes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Products",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                ProductBrandId = table.Column<int>(type: "INTEGER", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Products", x => x.Id);
                table.ForeignKey(
                    name: "FK_Products_ProductBrands_ProductBrandId",
                    column: x => x.ProductBrandId,
                    principalTable: "ProductBrands",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_Products_ProductTypes_CategoryId",
                    column: x => x.CategoryId,
                    principalTable: "ProductTypes",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "Review",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                VoterName = table.Column<string>(type: "TEXT", nullable: true),
                NumStars = table.Column<int>(type: "INTEGER", nullable: false),
                Comment = table.Column<string>(type: "TEXT", nullable: true),
                ProductId = table.Column<int>(type: "INTEGER", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Review", x => x.Id);
                table.ForeignKey(
                    name: "FK_Review_Products_ProductId",
                    column: x => x.ProductId,
                    principalTable: "Products",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateIndex(
            name: "IX_Products_CategoryId",
            table: "Products",
            column: "CategoryId");

        migrationBuilder.CreateIndex(
            name: "IX_Products_ProductBrandId",
            table: "Products",
            column: "ProductBrandId");

        migrationBuilder.CreateIndex(
            name: "IX_Review_ProductId",
            table: "Review",
            column: "ProductId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Review");

        migrationBuilder.DropTable(
            name: "Products");

        migrationBuilder.DropTable(
            name: "ProductBrands");

        migrationBuilder.DropTable(
            name: "ProductTypes");
    }
}
