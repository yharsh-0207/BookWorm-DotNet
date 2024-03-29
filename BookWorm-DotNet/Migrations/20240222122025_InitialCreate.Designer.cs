﻿// <auto-generated />
using System;
using BookWorm_DotNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookWorm_DotNet.Migrations
{
    [DbContext(typeof(BookwormContext))]
    [Migration("20240222122025_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookWorm_DotNet.Models.Attribute", b =>
                {
                    b.Property<long>("AttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AttributeId"));

                    b.Property<string>("AttributeDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("AttributeId")
                        .HasName("pk_attribute");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Beneficiary", b =>
                {
                    b.Property<long>("BeneficiaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BeneficiaryId"));

                    b.Property<string>("BeneficiaryAccNo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryAccType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryBankBranch")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryBankName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryContactNo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryEmailId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryIFSC")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BeneficiaryPAN")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("TotalEarning")
                        .HasColumnType("float");

                    b.HasKey("BeneficiaryId")
                        .HasName("pk_beneficiary");

                    b.ToTable("BeneficiaryMasters");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerId"));

                    b.Property<string>("City")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Country")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CustomerId")
                        .HasName("pk_customer");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Genre", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("GenreId"));

                    b.Property<string>("GenreDesc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("GenreId")
                        .HasName("PRIMARY");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Invoice", b =>
                {
                    b.Property<long>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InvoiceId"));

                    b.Property<double>("BuyAmount")
                        .HasColumnType("float");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<double>("InvoiceAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("RentAmount")
                        .HasColumnType("float");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("InvoiceId")
                        .HasName("pk_invoice");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.InvoiceDetail", b =>
                {
                    b.Property<long>("InvoiceDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InvoiceDetailId"));

                    b.Property<double>("BasePrice")
                        .HasColumnType("float");

                    b.Property<long>("InvoiceId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RentDays")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvoiceDetailId")
                        .HasName("pk_invoice_detail");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Language", b =>
                {
                    b.Property<long>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LanguageId"));

                    b.Property<string>("LanguageDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("LanguageId")
                        .HasName("pk_language");

                    b.ToTable("LanguageMasters");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.MyShelf", b =>
                {
                    b.Property<long>("ShelfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ShelfId"));

                    b.Property<long>("BuyId")
                        .HasColumnType("bigint");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("PriceAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("ProductExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("RentId")
                        .HasColumnType("bigint");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ShelfId")
                        .HasName("pk_myshelf");

                    b.ToTable("MyShelves");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Baseprice")
                        .HasColumnType("float");

                    b.Property<string>("DescriptionLong")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DescriptionShort")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("GenreId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsRentable")
                        .HasColumnType("bit");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("LanguageId")
                        .HasColumnType("bigint");

                    b.Property<int>("MinRentDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("OfferPriceExpirydate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Offerprice")
                        .HasColumnType("float");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("RentPerDay")
                        .HasColumnType("float");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<long>("ShelfId")
                        .HasColumnType("bigint");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId")
                        .HasName("pk_product");

                    b.HasIndex("GenreId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ShelfId");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductAttribute", b =>
                {
                    b.Property<long>("ProductAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductAttributeId"));

                    b.Property<long>("AttributeId")
                        .HasColumnType("bigint");

                    b.Property<string>("AttributeValue")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductAttributeId")
                        .HasName("pk_productattribute");

                    b.HasIndex("AttributeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttributes");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductBeneficiary", b =>
                {
                    b.Property<long>("ProductBeneficiaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductBeneficiaryId"));

                    b.Property<long>("BeneficiaryId")
                        .HasColumnType("bigint");

                    b.Property<double>("BeneficiaryPercentage")
                        .HasColumnType("float");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductBeneficiaryId")
                        .HasName("pk_productbeneficiary");

                    b.HasIndex("BeneficiaryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductBeneficiaries");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"));

                    b.Property<string>("TypeDesc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TypeId")
                        .HasName("pk_producttype");

                    b.ToTable("ProductTypeMasters");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductUrl", b =>
                {
                    b.Property<int>("UrlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrlId"));

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UrlId")
                        .HasName("pk_producturl");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductUrls");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.RoyaltyCalculation", b =>
                {
                    b.Property<long>("RoyaltyCalculationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoyaltyCalculationId"));

                    b.Property<double>("BasePrice")
                        .HasColumnType("float");

                    b.Property<long>("BeneficiaryId")
                        .HasColumnType("bigint");

                    b.Property<long>("InvoiceId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("RoyaltyCalculationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("RoyaltyOnBasePrice")
                        .HasColumnType("float");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("RoyaltyCalculationId")
                        .HasName("pk_royaltycalculation");

                    b.ToTable("RoyaltyCalculations");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Invoice", b =>
                {
                    b.HasOne("BookWorm_DotNet.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.InvoiceDetail", b =>
                {
                    b.HasOne("BookWorm_DotNet.Models.Invoice", "Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWorm_DotNet.Models.Product", "Product")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Product", b =>
                {
                    b.HasOne("BookWorm_DotNet.Models.Genre", "Genre")
                        .WithMany("Products")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWorm_DotNet.Models.Language", "Language")
                        .WithMany("Products")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWorm_DotNet.Models.MyShelf", "Shelf")
                        .WithMany("Products")
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWorm_DotNet.Models.ProductType", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Language");

                    b.Navigation("Shelf");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductAttribute", b =>
                {
                    b.HasOne("BookWorm_DotNet.Models.Attribute", "Attribute")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("AttributeId")
                        .IsRequired();

                    b.HasOne("BookWorm_DotNet.Models.Product", "Product")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductBeneficiary", b =>
                {
                    b.HasOne("BookWorm_DotNet.Models.Beneficiary", "Beneficiary")
                        .WithMany("ProductBeneficiaries")
                        .HasForeignKey("BeneficiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWorm_DotNet.Models.Product", "Product")
                        .WithMany("ProductBeneficiaries")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beneficiary");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductUrl", b =>
                {
                    b.HasOne("BookWorm_DotNet.Models.Product", "Product")
                        .WithOne("ProductUrl")
                        .HasForeignKey("BookWorm_DotNet.Models.ProductUrl", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Attribute", b =>
                {
                    b.Navigation("ProductAttributes");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Beneficiary", b =>
                {
                    b.Navigation("ProductBeneficiaries");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Genre", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Invoice", b =>
                {
                    b.Navigation("InvoiceDetails");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Language", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.MyShelf", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.Product", b =>
                {
                    b.Navigation("InvoiceDetails");

                    b.Navigation("ProductAttributes");

                    b.Navigation("ProductBeneficiaries");

                    b.Navigation("ProductUrl")
                        .IsRequired();
                });

            modelBuilder.Entity("BookWorm_DotNet.Models.ProductType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
