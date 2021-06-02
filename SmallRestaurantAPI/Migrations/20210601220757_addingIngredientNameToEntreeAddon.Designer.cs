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
    [Migration("20210601220757_addingIngredientNameToEntreeAddon")]
    partial class addingIngredientNameToEntreeAddon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("IngredientName")
                        .HasColumnType("nvarchar(max)");

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
#pragma warning restore 612, 618
        }
    }
}