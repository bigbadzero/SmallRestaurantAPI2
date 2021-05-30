﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallRestaurantAPI.Data;

namespace SmallRestaurantAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("Condiment1ID")
                        .HasColumnType("int");

                    b.Property<int?>("Condiment2ID")
                        .HasColumnType("int");

                    b.Property<int?>("Condiment3ID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("DrinkID")
                        .HasColumnType("int");

                    b.Property<int>("EntreeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SideID")
                        .HasColumnType("int");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("Condiment1ID");

                    b.HasIndex("Condiment2ID");

                    b.HasIndex("Condiment3ID");

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

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

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

                    b.Property<int?>("Condiment1ID")
                        .HasColumnType("int");

                    b.Property<int?>("Condiment2ID")
                        .HasColumnType("int");

                    b.Property<int?>("Condiment3ID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Ingredient10ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient11ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient12ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient13ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient14ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient15ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient16ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient17ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient18ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient19ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient1ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient2ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient3ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient4ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient5ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient6ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient7ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient8ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient9ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("Condiment1ID");

                    b.HasIndex("Condiment2ID");

                    b.HasIndex("Condiment3ID");

                    b.HasIndex("Ingredient10ID");

                    b.HasIndex("Ingredient11ID");

                    b.HasIndex("Ingredient12ID");

                    b.HasIndex("Ingredient13ID");

                    b.HasIndex("Ingredient14ID");

                    b.HasIndex("Ingredient15ID");

                    b.HasIndex("Ingredient16ID");

                    b.HasIndex("Ingredient17ID");

                    b.HasIndex("Ingredient18ID");

                    b.HasIndex("Ingredient19ID");

                    b.HasIndex("Ingredient1ID");

                    b.HasIndex("Ingredient2ID");

                    b.HasIndex("Ingredient3ID");

                    b.HasIndex("Ingredient4ID");

                    b.HasIndex("Ingredient5ID");

                    b.HasIndex("Ingredient6ID");

                    b.HasIndex("Ingredient7ID");

                    b.HasIndex("Ingredient8ID");

                    b.HasIndex("Ingredient9ID");

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

                    b.Property<int?>("Ingredient10ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient11ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient12ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient13ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient14ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient15ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient16ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient17ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient18ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient19ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient1ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient2ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient3ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient4ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient5ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient6ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient7ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient8ID")
                        .HasColumnType("int");

                    b.Property<int?>("Ingredient9ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntreeID");

                    b.HasIndex("Ingredient10ID");

                    b.HasIndex("Ingredient11ID");

                    b.HasIndex("Ingredient12ID");

                    b.HasIndex("Ingredient13ID");

                    b.HasIndex("Ingredient14ID");

                    b.HasIndex("Ingredient15ID");

                    b.HasIndex("Ingredient16ID");

                    b.HasIndex("Ingredient17ID");

                    b.HasIndex("Ingredient18ID");

                    b.HasIndex("Ingredient19ID");

                    b.HasIndex("Ingredient1ID");

                    b.HasIndex("Ingredient2ID");

                    b.HasIndex("Ingredient3ID");

                    b.HasIndex("Ingredient4ID");

                    b.HasIndex("Ingredient5ID");

                    b.HasIndex("Ingredient6ID");

                    b.HasIndex("Ingredient7ID");

                    b.HasIndex("Ingredient8ID");

                    b.HasIndex("Ingredient9ID");

                    b.ToTable("EntreeAddons");
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

                    b.Property<bool?>("isRequired")
                        .HasColumnType("bit");

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

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Condiment1")
                        .WithMany()
                        .HasForeignKey("Condiment1ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Condiment2")
                        .WithMany()
                        .HasForeignKey("Condiment2ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Condiment3")
                        .WithMany()
                        .HasForeignKey("Condiment3ID");

                    b.HasOne("SmallRestaurantAPI.Data.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Entree", "Entree")
                        .WithMany()
                        .HasForeignKey("EntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Side", "Side")
                        .WithMany()
                        .HasForeignKey("SideID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Condiment1");

                    b.Navigation("Condiment2");

                    b.Navigation("Condiment3");

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

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Condiment1")
                        .WithMany()
                        .HasForeignKey("Condiment1ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Condiment2")
                        .WithMany()
                        .HasForeignKey("Condiment2ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Condiment3")
                        .WithMany()
                        .HasForeignKey("Condiment3ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient10")
                        .WithMany()
                        .HasForeignKey("Ingredient10ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient11")
                        .WithMany()
                        .HasForeignKey("Ingredient11ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient12")
                        .WithMany()
                        .HasForeignKey("Ingredient12ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient13")
                        .WithMany()
                        .HasForeignKey("Ingredient13ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient14")
                        .WithMany()
                        .HasForeignKey("Ingredient14ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient15")
                        .WithMany()
                        .HasForeignKey("Ingredient15ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient16")
                        .WithMany()
                        .HasForeignKey("Ingredient16ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient17")
                        .WithMany()
                        .HasForeignKey("Ingredient17ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient18")
                        .WithMany()
                        .HasForeignKey("Ingredient18ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient19")
                        .WithMany()
                        .HasForeignKey("Ingredient19ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient1")
                        .WithMany()
                        .HasForeignKey("Ingredient1ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient2")
                        .WithMany()
                        .HasForeignKey("Ingredient2ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient3")
                        .WithMany()
                        .HasForeignKey("Ingredient3ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient4")
                        .WithMany()
                        .HasForeignKey("Ingredient4ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient5")
                        .WithMany()
                        .HasForeignKey("Ingredient5ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient6")
                        .WithMany()
                        .HasForeignKey("Ingredient6ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient7")
                        .WithMany()
                        .HasForeignKey("Ingredient7ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient8")
                        .WithMany()
                        .HasForeignKey("Ingredient8ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient9")
                        .WithMany()
                        .HasForeignKey("Ingredient9ID");

                    b.HasOne("SmallRestaurantAPI.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Condiment1");

                    b.Navigation("Condiment2");

                    b.Navigation("Condiment3");

                    b.Navigation("Ingredient1");

                    b.Navigation("Ingredient10");

                    b.Navigation("Ingredient11");

                    b.Navigation("Ingredient12");

                    b.Navigation("Ingredient13");

                    b.Navigation("Ingredient14");

                    b.Navigation("Ingredient15");

                    b.Navigation("Ingredient16");

                    b.Navigation("Ingredient17");

                    b.Navigation("Ingredient18");

                    b.Navigation("Ingredient19");

                    b.Navigation("Ingredient2");

                    b.Navigation("Ingredient3");

                    b.Navigation("Ingredient4");

                    b.Navigation("Ingredient5");

                    b.Navigation("Ingredient6");

                    b.Navigation("Ingredient7");

                    b.Navigation("Ingredient8");

                    b.Navigation("Ingredient9");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("SmallRestaurantAPI.Data.EntreeAddon", b =>
                {
                    b.HasOne("SmallRestaurantAPI.Data.Entree", "Entree")
                        .WithMany()
                        .HasForeignKey("EntreeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient10")
                        .WithMany()
                        .HasForeignKey("Ingredient10ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient11")
                        .WithMany()
                        .HasForeignKey("Ingredient11ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient12")
                        .WithMany()
                        .HasForeignKey("Ingredient12ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient13")
                        .WithMany()
                        .HasForeignKey("Ingredient13ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient14")
                        .WithMany()
                        .HasForeignKey("Ingredient14ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient15")
                        .WithMany()
                        .HasForeignKey("Ingredient15ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient16")
                        .WithMany()
                        .HasForeignKey("Ingredient16ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient17")
                        .WithMany()
                        .HasForeignKey("Ingredient17ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient18")
                        .WithMany()
                        .HasForeignKey("Ingredient18ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient19")
                        .WithMany()
                        .HasForeignKey("Ingredient19ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient1")
                        .WithMany()
                        .HasForeignKey("Ingredient1ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient2")
                        .WithMany()
                        .HasForeignKey("Ingredient2ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient3")
                        .WithMany()
                        .HasForeignKey("Ingredient3ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient4")
                        .WithMany()
                        .HasForeignKey("Ingredient4ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient5")
                        .WithMany()
                        .HasForeignKey("Ingredient5ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient6")
                        .WithMany()
                        .HasForeignKey("Ingredient6ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient7")
                        .WithMany()
                        .HasForeignKey("Ingredient7ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient8")
                        .WithMany()
                        .HasForeignKey("Ingredient8ID");

                    b.HasOne("SmallRestaurantAPI.Data.Ingredient", "Ingredient9")
                        .WithMany()
                        .HasForeignKey("Ingredient9ID");

                    b.Navigation("Entree");

                    b.Navigation("Ingredient1");

                    b.Navigation("Ingredient10");

                    b.Navigation("Ingredient11");

                    b.Navigation("Ingredient12");

                    b.Navigation("Ingredient13");

                    b.Navigation("Ingredient14");

                    b.Navigation("Ingredient15");

                    b.Navigation("Ingredient16");

                    b.Navigation("Ingredient17");

                    b.Navigation("Ingredient18");

                    b.Navigation("Ingredient19");

                    b.Navigation("Ingredient2");

                    b.Navigation("Ingredient3");

                    b.Navigation("Ingredient4");

                    b.Navigation("Ingredient5");

                    b.Navigation("Ingredient6");

                    b.Navigation("Ingredient7");

                    b.Navigation("Ingredient8");

                    b.Navigation("Ingredient9");
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
#pragma warning restore 612, 618
        }
    }
}
