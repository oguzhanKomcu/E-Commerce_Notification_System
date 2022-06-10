﻿// <auto-generated />
using System;
using ECNS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECNS.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bc5308af-f3c9-4a16-ba12-9cfad2da6f30",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1cc51cc4-2120-47ce-bcec-055cfdb9b5e0",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(7135),
                            Email = "sezer@gmail.com",
                            EmailConfirmed = false,
                            First_Name = "Sezer",
                            Last_Name = "Turan",
                            LockoutEnabled = false,
                            PasswordHash = "123",
                            PhoneNumber = "05345647541",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d139ce66-4959-43a2-8ec6-372a965457cf",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "sezer1"
                        },
                        new
                        {
                            Id = "074c7ad6-05e8-4bff-bb2f-0d6b1c820c9e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "732fe12d-beaf-4b52-b9ce-f22a9f9e6f27",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(7159),
                            Email = "batuhan@gmail.com",
                            EmailConfirmed = false,
                            First_Name = "Batuhan",
                            Last_Name = "Kara",
                            LockoutEnabled = false,
                            PasswordHash = "123",
                            PhoneNumber = "05345648996",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3ecb67ae-f011-4da7-b2e3-aca39a4d6633",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "batuhan1"
                        },
                        new
                        {
                            Id = "1db6b78a-b77b-4673-a750-ffc3138785c4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "13457edd-4d62-4136-b89d-fcb87ad84cfa",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(7167),
                            Email = "furkan@gmail.com",
                            EmailConfirmed = false,
                            First_Name = "Furkan",
                            Last_Name = "Yılmaz",
                            LockoutEnabled = false,
                            PasswordHash = "123",
                            PhoneNumber = "05345647848",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ed2c6ec-59a6-4d34-97b0-f1bf5e0cf233",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "furkan1"
                        },
                        new
                        {
                            Id = "9f889587-cecd-4252-bfac-02be3f84bedf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f09ded33-5d2b-4ad7-a118-e5437c797b99",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(7175),
                            Email = "ozan@gmail.com",
                            EmailConfirmed = false,
                            First_Name = "Ozan",
                            Last_Name = "Eser",
                            LockoutEnabled = false,
                            PasswordHash = "123",
                            PhoneNumber = "05345645623",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2eff40d7-6889-46d2-8547-5f03055c4a4f",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "ozan1"
                        });
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Product_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6692),
                            Name = "Teknology",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6706),
                            Name = "Vacuum Flasks & Mugs",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6707),
                            Name = "Sneakers",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6708),
                            Name = "Cordless Drills",
                            Status = 1
                        });
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Order_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("Payment_ID")
                        .HasColumnType("int");

                    b.Property<int>("Shipping_Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("Shipping_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Order_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Order_Details");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PaymentS");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category_Id = 1,
                            Color = "Black",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6955),
                            Description = "As part of our efforts to achieve our environmental goals, the iPhone 12 and iPhone 12 are not offered with a mini power adapter or EarPods. The box contains a USB-C - Lightning cable that supports fast charging, compatible with USB-C power adapters and computer ports.",
                            ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /iphone.jpg",
                            Name = "iPhone 12",
                            Price = 1100m,
                            Size = "146.7 x 71.5 x 7.4",
                            Status = 1,
                            Stock = 300
                        },
                        new
                        {
                            Id = 2,
                            Category_Id = 1,
                            Color = "Black",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6960),
                            Description = "A11SCX-223TR Intel Core i7 1185G7 8GB 512GB SSD GTX1650 Windows 10 Home 15.6 FHD Laptop",
                            ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /msi.jpg",
                            Name = "MSI Prestige 15",
                            Price = 2000m,
                            Size = "15,6 inç",
                            Status = 1,
                            Stock = 150
                        },
                        new
                        {
                            Id = 4,
                            Category_Id = 2,
                            Color = "Green",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6962),
                            Description = "Boasting stainless steel vacuum insulation, this double walled Classic 750ml vacuum flask from Stanley is perfect for keeping hot drinks hot and cold drinks cold for up to 20 hours (04 days for ice).",
                            ImagePath = "C:/Users/Desktop/E-Commerce_Website/E-Commerce_Website_Basic_Project/Src/Web/EWBP.Presantation/wwwroot/Image/Product/stanley.jpg",
                            Name = "New STANLEY Classic Vacuum Insulated 750ml Bottle Thermos Flask",
                            Price = 50m,
                            Size = "8.50cm Diameter - 30 cm Height",
                            Status = 1,
                            Stock = 250
                        },
                        new
                        {
                            Id = 5,
                            Category_Id = 3,
                            Color = "Black and White",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6965),
                            Description = "New with box: A brand - new,unused,and unworn item(including handmade items) in the original packaging(such as the original box or bag) and / or with the original tags attached.",
                            ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /new-balance.png",
                            Name = "[New Balance] Retro 530 Silber SG Paar Laufschuhe Sportschuhe",
                            Price = 104m,
                            Size = "us5-us10",
                            Status = 1,
                            Stock = 80
                        },
                        new
                        {
                            Id = 6,
                            Category_Id = 4,
                            Color = "Green",
                            CreateDate = new DateTime(2022, 6, 10, 17, 53, 21, 941, DateTimeKind.Local).AddTicks(6966),
                            Description = "Higher impact power and high performance in hard material with pneumatic mechanism",
                            ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /s-l1600.jpg",
                            Name = "Bosch UniversalDrill ",
                            Price = 110m,
                            Size = "30,3 x 22,8 x 9,1 cm",
                            Status = 1,
                            Stock = 50
                        });
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Shipper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Cart", b =>
                {
                    b.HasOne("ECNS.Domainn.Models.Entities.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECNS.Domainn.Models.Entities.AppUser", "AppUser")
                        .WithMany("Carts")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Order", b =>
                {
                    b.HasOne("ECNS.Domainn.Models.Entities.Payment", null)
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId");

                    b.HasOne("ECNS.Domainn.Models.Entities.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("Shipping_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECNS.Domainn.Models.Entities.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Order_Detail", b =>
                {
                    b.HasOne("ECNS.Domainn.Models.Entities.Order", "Order")
                        .WithMany("Order_Details")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECNS.Domainn.Models.Entities.Product", "Product")
                        .WithMany("Order_Details")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECNS.Domainn.Models.Entities.Supplier", null)
                        .WithMany("OrderDetail")
                        .HasForeignKey("SupplierId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Product", b =>
                {
                    b.HasOne("ECNS.Domainn.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ECNS.Domainn.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ECNS.Domainn.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECNS.Domainn.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ECNS.Domainn.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.AppUser", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Order", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ECNS.Domainn.Models.Entities.Supplier", b =>
                {
                    b.Navigation("OrderDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
