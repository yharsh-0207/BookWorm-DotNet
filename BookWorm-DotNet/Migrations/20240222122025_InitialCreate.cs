using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm_DotNet.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    AttributeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_attribute", x => x.AttributeId);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiaryMasters",
                columns: table => new
                {
                    BeneficiaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeneficiaryAccNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryAccType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryBankBranch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryBankName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryContactNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryEmailId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryIFSC = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BeneficiaryPAN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TotalEarning = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_beneficiary", x => x.BeneficiaryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "LanguageMasters",
                columns: table => new
                {
                    LanguageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "MyShelves",
                columns: table => new
                {
                    ShelfId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BuyId = table.Column<long>(type: "bigint", nullable: false),
                    PriceAmount = table.Column<double>(type: "float", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RentId = table.Column<long>(type: "bigint", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_myshelf", x => x.ShelfId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeMasters",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_producttype", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "RoyaltyCalculations",
                columns: table => new
                {
                    RoyaltyCalculationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasePrice = table.Column<double>(type: "float", nullable: false),
                    BeneficiaryId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    RoyaltyCalculationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoyaltyOnBasePrice = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_royaltycalculation", x => x.RoyaltyCalculationId);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceAmount = table.Column<double>(type: "float", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    BuyAmount = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RentAmount = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_invoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRentable = table.Column<bool>(type: "bit", nullable: false),
                    MinRentDays = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Baseprice = table.Column<double>(type: "float", nullable: false),
                    DescriptionLong = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DescriptionShort = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OfferPriceExpirydate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Offerprice = table.Column<double>(type: "float", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    RentPerDay = table.Column<double>(type: "float", nullable: false),
                    GenreId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    ShelfId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_LanguageMasters_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "LanguageMasters",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MyShelves_ShelfId",
                        column: x => x.ShelfId,
                        principalTable: "MyShelves",
                        principalColumn: "ShelfId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypeMasters_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProductTypeMasters",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasePrice = table.Column<double>(type: "float", nullable: false),
                    RentDays = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_invoice_detail", x => x.InvoiceDetailId);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    ProductAttributeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    AttributeValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_productattribute", x => x.ProductAttributeId);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "AttributeId");
                    table.ForeignKey(
                        name: "FK_ProductAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductBeneficiaries",
                columns: table => new
                {
                    ProductBeneficiaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeneficiaryId = table.Column<long>(type: "bigint", nullable: false),
                    BeneficiaryPercentage = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_productbeneficiary", x => x.ProductBeneficiaryId);
                    table.ForeignKey(
                        name: "FK_ProductBeneficiaries_BeneficiaryMasters_BeneficiaryId",
                        column: x => x.BeneficiaryId,
                        principalTable: "BeneficiaryMasters",
                        principalColumn: "BeneficiaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductBeneficiaries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductUrls",
                columns: table => new
                {
                    UrlId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_producturl", x => x.UrlId);
                    table.ForeignKey(
                        name: "FK_ProductUrls_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_ProductId",
                table: "InvoiceDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_AttributeId",
                table: "ProductAttributes",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBeneficiaries_BeneficiaryId",
                table: "ProductBeneficiaries",
                column: "BeneficiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBeneficiaries_ProductId",
                table: "ProductBeneficiaries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenreId",
                table: "Products",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LanguageId",
                table: "Products",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShelfId",
                table: "Products",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeId",
                table: "Products",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUrls_ProductId",
                table: "ProductUrls",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "ProductBeneficiaries");

            migrationBuilder.DropTable(
                name: "ProductUrls");

            migrationBuilder.DropTable(
                name: "RoyaltyCalculations");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "BeneficiaryMasters");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "LanguageMasters");

            migrationBuilder.DropTable(
                name: "MyShelves");

            migrationBuilder.DropTable(
                name: "ProductTypeMasters");
        }
    }
}
