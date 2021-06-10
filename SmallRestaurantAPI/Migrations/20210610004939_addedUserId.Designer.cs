﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallRestaurantAPI.Data;

namespace SmallRestaurantAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210610004939_addedUserId")]
    partial class addedUserId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "6a86fdec-877e-487b-8c39-86d9cb8fb328",
                            ConcurrencyStamp = "574105b3-cf87-4615-9bbb-6c86e51f7141",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "1411b65b-e2ba-459a-86c3-d2129b4bcf64",
                            ConcurrencyStamp = "9e4c10d4-fb93-4072-99b3-1c91e46cc6da",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
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

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Cart", b =>
                {
                    b.Property<string>("UserID")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ComboID")
                        .HasColumnType("int");

                    b.Property<int?>("DrinkID")
                        .HasColumnType("int");

                    b.Property<Guid?>("SelectedEntreeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SideID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("ComboID");

                    b.HasIndex("DrinkID");

                    b.HasIndex("SelectedEntreeID");

                    b.HasIndex("SideID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Combo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("ComboNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("ComboSizeOverride")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("DrinkID")
                        .HasColumnType("int");

                    b.Property<int>("EntreeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SideID")
                        .HasColumnType("int");

                    b.Property<int?>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("DrinkID");

                    b.HasIndex("EntreeID");

                    b.HasIndex("SideID");

                    b.HasIndex("SizeID");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Condiment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Condiments");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Drink", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SizeID");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Entree", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SizeID");

                    b.ToTable("Entrees");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.EntreeAddon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntreeID")
                        .HasColumnType("int");

                    b.Property<int>("IngredientID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntreeID");

                    b.HasIndex("IngredientID");

                    b.ToTable("EntreeAddons");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.EntreeBaseIngredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntreeID")
                        .HasColumnType("int");

                    b.Property<int>("IngredientID")
                        .HasColumnType("int");

                    b.Property<bool?>("isRequired")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("EntreeID");

                    b.HasIndex("IngredientID");

                    b.ToTable("EntreeBaseIngredients");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.EntreeSize", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntreeID")
                        .HasColumnType("int");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EntreeID");

                    b.HasIndex("SizeID");

                    b.ToTable("EntreeSizes");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.SelectedEntree", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EntreeID")
                        .HasColumnType("int");

                    b.Property<int?>("SizeID")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("EntreeID");

                    b.HasIndex("UserId");

                    b.ToTable("SelectedEntrees");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.SelectedIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<Guid>("SelectedEntreeID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("SelectedEntreeID");

                    b.ToTable("SelectedIngredients");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Side", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SizeID");

                    b.ToTable("Sides");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.SideAddon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IngredientID")
                        .HasColumnType("int");

                    b.Property<int>("SideID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IngredientID");

                    b.HasIndex("SideID");

                    b.ToTable("SideAddons");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Size", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ID");

                    b.ToTable("Sizes");
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
                    b.HasOne("SmallRestaurantAPI.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.ApiUser", null)
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

                    b.HasOne("SmallRestaurantAPI.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Cart", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Combo", "Combo")
                        .WithMany()
                        .HasForeignKey("ComboID");

                    b.HasOne("SmallRestaurantAPI.Data.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkID");

                    b.HasOne("SmallRestaurantAPI.Data.SelectedEntree", "selectedEntree")
                        .WithMany()
                        .HasForeignKey("SelectedEntreeID");

                    b.HasOne("SmallRestaurantAPI.Data.Side", "Side")
                        .WithMany()
                        .HasForeignKey("SideID");

                    b.HasOne("SmallRestaurantAPI.Data.ApiUser", "ApiUser")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiUser");

                    b.Navigation("Combo");

                    b.Navigation("Drink");

                    b.Navigation("selectedEntree");

                    b.Navigation("Side");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Combo", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkID");

                    b.HasOne("SmallRestaurantAPI.Data.Entree", "Entree")
                        .WithMany()
                        .HasForeignKey("EntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Side", "Side")
                        .WithMany()
                        .HasForeignKey("SideID");

                    b.HasOne("SmallRestaurantAPI.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID");

                    b.Navigation("Category");

                    b.Navigation("Drink");

                    b.Navigation("Entree");

                    b.Navigation("Side");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Condiment", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Drink", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Entree", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID");

                    b.Navigation("Category");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.EntreeAddon", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Entree", "Entree")
                        .WithMany("EntreeAddons")
                        .HasForeignKey("EntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entree");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.EntreeBaseIngredient", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Entree", "Entree")
                        .WithMany("EntreeBaseIngredients")
                        .HasForeignKey("EntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entree");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.EntreeSize", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Entree", "Entree")
                        .WithMany("EntreeSizes")
                        .HasForeignKey("EntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entree");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.SelectedEntree", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Entree", "Entree")
                        .WithMany()
                        .HasForeignKey("EntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.ApiUser", "ApiUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApiUser");

                    b.Navigation("Entree");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.SelectedIngredient", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.SelectedEntree", "SelectedEntree")
                        .WithMany("SelectedIngredients")
                        .HasForeignKey("SelectedEntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("SelectedEntree");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Side", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.SideAddon", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientID");

                    b.HasOne("SmallRestaurantAPI.Data.Side", "Side")
                        .WithMany()
                        .HasForeignKey("SideID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Side");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.Entree", b =>
                {
                    b.Navigation("EntreeAddons");

                    b.Navigation("EntreeBaseIngredients");

                    b.Navigation("EntreeSizes");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.SelectedEntree", b =>
                {
                    b.Navigation("SelectedIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
