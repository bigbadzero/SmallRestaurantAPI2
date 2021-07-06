using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItemStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItemStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Condiments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CartItemStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartItems_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_CartItemStatuses_CartItemStatusID",
                        column: x => x.CartItemStatusID,
                        principalTable: "CartItemStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Drinks_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entrees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entrees_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entrees_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sides",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sides", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sides_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Items_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntreeAddons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeAddons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntreeBaseIngredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeBaseIngredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EntreeBaseIngredients_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeBaseIngredients_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntreeSizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeSizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EntreeSizes_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeSizes_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedEntrees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    CartItemID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedEntrees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SelectedEntrees_CartItems_CartItemID",
                        column: x => x.CartItemID,
                        principalTable: "CartItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedEntrees_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedEntrees_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SelectedSides",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    CartItemID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedSides", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SelectedSides_CartItems_CartItemID",
                        column: x => x.CartItemID,
                        principalTable: "CartItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedSides_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedSides_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SideAddons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideAddons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SideAddons_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideAddons_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SideBaseIngredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideBaseIngredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SideBaseIngredients_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SideBaseIngredients_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SideSizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideSizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SideSizes_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SideSizes_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ComboNumber = table.Column<int>(type: "int", nullable: false),
                    ComboSizeOverride = table.Column<bool>(type: "bit", nullable: true),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    SideID = table.Column<int>(type: "int", nullable: true),
                    DrinkID = table.Column<int>(type: "int", nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Combos_Items_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combos_Items_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Combos_Items_SideID",
                        column: x => x.SideID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combos_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemAvailableAddons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAvailableAddons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemAvailableAddons_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemAvailableAddons_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemBaseIngredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBaseIngredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemBaseIngredients_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemBaseIngredients_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCategories_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemSizes_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSizes_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedEntreeIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedEntreeID = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedEntreeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedEntreeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedEntreeIngredients_SelectedEntrees_SelectedEntreeID",
                        column: x => x.SelectedEntreeID,
                        principalTable: "SelectedEntrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedSideIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedSideID = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedSideIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedSideIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedSideIngredients_SelectedSides_SelectedSideID",
                        column: x => x.SelectedSideID,
                        principalTable: "SelectedSides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComboDrinkItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    ComboID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboDrinkItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComboDrinkItems_Combos_ComboID",
                        column: x => x.ComboID,
                        principalTable: "Combos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboDrinkItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComboDrinkItems_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComboSideItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    ComboID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboSideItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComboSideItems_Combos_ComboID",
                        column: x => x.ComboID,
                        principalTable: "Combos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboSideItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComboSideItems_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8cb2de16-9371-4d66-9817-dd3ccb5def4b", "65c4d55b-ca28-441b-9d73-bbdb8e36147a", "User", "USER" },
                    { "980c81d8-c660-4042-a64f-ade192d02cf3", "a5120976-9914-42a2-a4d0-3fba32f12889", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "CartItemStatuses",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Ordering" },
                    { 2, "Order Processing" },
                    { 3, "Order Ready" },
                    { 4, "Order Complete" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Burgers" },
                    { 2, "Chicken" },
                    { 3, "Pizza" },
                    { 4, "Test" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "ID", "Description", "Name", "SizeID" },
                values: new object[,]
                {
                    { 3, null, "Dr.Pepper", null },
                    { 1, null, "Sweat Tea", null },
                    { 2, null, "Coke", null }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 11, null, "Shredded Cheese" },
                    { 18, null, "Coke" },
                    { 17, null, "Onion Rings" },
                    { 16, null, "French Fries" },
                    { 15, null, "Pineapple" },
                    { 14, null, "Buffalo Sauce" },
                    { 13, null, "Bacon" },
                    { 12, null, "Pepperoni" },
                    { 10, null, "Pizza Sauce" },
                    { 7, null, "Pickle" },
                    { 8, null, "Chicken Finger" },
                    { 6, null, "Onion" },
                    { 5, null, "Mustard" },
                    { 4, null, "Ketchup" },
                    { 3, null, "Sliced Cheese" },
                    { 2, null, "Hamburger Patty" },
                    { 1, null, "Hamburger bun" },
                    { 9, null, "Pizza Crust" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "ID", "Description", "Name", "SizeID" },
                values: new object[,]
                {
                    { 2, null, "Onion Rings", null },
                    { 1, null, "French Fries", null }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "S" },
                    { 2, "M" },
                    { 3, "L" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Entree" },
                    { 2, "Side" },
                    { 3, "Drink" },
                    { 4, "Combo" }
                });

            migrationBuilder.InsertData(
                table: "Entrees",
                columns: new[] { "ID", "CategoryID", "Description", "Name", "SizeID" },
                values: new object[,]
                {
                    { 1, 1, null, "Cheese Burger", null },
                    { 2, 2, null, "3 Piece Chicken Finger", null },
                    { 3, 3, null, "Pepperoni Pizza", null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Description", "Name", "TypeID" },
                values: new object[,]
                {
                    { 1, null, "CheeseBurger", 1 },
                    { 2, null, "Hamburger", 1 },
                    { 3, null, "Fries", 2 },
                    { 4, null, "Coke", 3 }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "ID", "ComboNumber", "ComboSizeOverride", "Description", "DrinkID", "EntreeID", "Name", "SideID", "SizeID" },
                values: new object[] { 1, 1, null, null, null, 1, "Cheese Burger Combo", null, null });

            migrationBuilder.InsertData(
                table: "EntreeAddons",
                columns: new[] { "ID", "EntreeID", "IngredientID" },
                values: new object[,]
                {
                    { 1, 1, 13 },
                    { 3, 3, 15 },
                    { 2, 2, 14 }
                });

            migrationBuilder.InsertData(
                table: "EntreeBaseIngredients",
                columns: new[] { "ID", "EntreeID", "IngredientID", "isRequired" },
                values: new object[,]
                {
                    { 14, 3, 12, false },
                    { 13, 3, 11, true },
                    { 12, 3, 10, true },
                    { 10, 2, 8, true },
                    { 9, 2, 8, true },
                    { 11, 3, 9, true },
                    { 7, 1, 7, false },
                    { 6, 1, 6, false },
                    { 5, 1, 5, false },
                    { 8, 2, 8, true },
                    { 4, 1, 4, false },
                    { 3, 1, 3, false },
                    { 2, 1, 2, true },
                    { 1, 1, 1, true }
                });

            migrationBuilder.InsertData(
                table: "ItemAvailableAddons",
                columns: new[] { "ID", "IngredientID", "ItemID" },
                values: new object[,]
                {
                    { 1, 13, 1 },
                    { 2, 13, 2 }
                });

            migrationBuilder.InsertData(
                table: "ItemBaseIngredients",
                columns: new[] { "ID", "IngredientID", "ItemID", "isRequired" },
                values: new object[,]
                {
                    { 15, 18, 4, true },
                    { 14, 16, 3, true },
                    { 13, 7, 2, false },
                    { 12, 6, 2, false },
                    { 11, 5, 2, false },
                    { 10, 4, 2, false },
                    { 9, 2, 2, true },
                    { 8, 1, 2, true },
                    { 5, 5, 1, false },
                    { 7, 7, 1, false },
                    { 6, 6, 1, false },
                    { 4, 4, 1, false },
                    { 3, 3, 1, false },
                    { 1, 1, 1, true },
                    { 2, 2, 1, true }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "ID", "CategoryID", "ItemID" },
                values: new object[,]
                {
                    { 2, 4, 1 },
                    { 1, 1, 1 },
                    { 3, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "ItemSizes",
                columns: new[] { "ID", "ItemID", "SizeID" },
                values: new object[,]
                {
                    { 2, 1, 3 },
                    { 8, 4, 1 },
                    { 7, 3, 3 },
                    { 6, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ItemSizes",
                columns: new[] { "ID", "ItemID", "SizeID" },
                values: new object[,]
                {
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 1, 1, 2 },
                    { 9, 4, 2 },
                    { 5, 3, 1 },
                    { 10, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartItemStatusID",
                table: "CartItems",
                column: "CartItemStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserID",
                table: "CartItems",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ComboDrinkItems_ComboID",
                table: "ComboDrinkItems",
                column: "ComboID");

            migrationBuilder.CreateIndex(
                name: "IX_ComboDrinkItems_ItemID",
                table: "ComboDrinkItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ComboDrinkItems_TypeID",
                table: "ComboDrinkItems",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_DrinkID",
                table: "Combos",
                column: "DrinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_EntreeID",
                table: "Combos",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_SideID",
                table: "Combos",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_SizeID",
                table: "Combos",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_ComboSideItems_ComboID",
                table: "ComboSideItems",
                column: "ComboID");

            migrationBuilder.CreateIndex(
                name: "IX_ComboSideItems_ItemID",
                table: "ComboSideItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ComboSideItems_TypeID",
                table: "ComboSideItems",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_SizeID",
                table: "Drinks",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_EntreeID",
                table: "EntreeAddons",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_IngredientID",
                table: "EntreeAddons",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeBaseIngredients_EntreeID",
                table: "EntreeBaseIngredients",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeBaseIngredients_IngredientID",
                table: "EntreeBaseIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_CategoryID",
                table: "Entrees",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_SizeID",
                table: "Entrees",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeSizes_EntreeID",
                table: "EntreeSizes",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeSizes_SizeID",
                table: "EntreeSizes",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAvailableAddons_IngredientID",
                table: "ItemAvailableAddons",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAvailableAddons_ItemID",
                table: "ItemAvailableAddons",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBaseIngredients_IngredientID",
                table: "ItemBaseIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBaseIngredients_ItemID",
                table: "ItemBaseIngredients",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategories_CategoryID",
                table: "ItemCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategories_ItemID",
                table: "ItemCategories",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TypeID",
                table: "Items",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSizes_ItemID",
                table: "ItemSizes",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSizes_SizeID",
                table: "ItemSizes",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntreeIngredients_IngredientId",
                table: "SelectedEntreeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntreeIngredients_SelectedEntreeID",
                table: "SelectedEntreeIngredients",
                column: "SelectedEntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntrees_CartItemID",
                table: "SelectedEntrees",
                column: "CartItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntrees_EntreeID",
                table: "SelectedEntrees",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntrees_SizeID",
                table: "SelectedEntrees",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSideIngredients_IngredientId",
                table: "SelectedSideIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSideIngredients_SelectedSideID",
                table: "SelectedSideIngredients",
                column: "SelectedSideID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSides_CartItemID",
                table: "SelectedSides",
                column: "CartItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSides_SideID",
                table: "SelectedSides",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSides_SizeID",
                table: "SelectedSides",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_IngredientID",
                table: "SideAddons",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_SideID",
                table: "SideAddons",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_SideBaseIngredients_IngredientID",
                table: "SideBaseIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_SideBaseIngredients_SideID",
                table: "SideBaseIngredients",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_Sides_SizeID",
                table: "Sides",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_SideSizes_SideID",
                table: "SideSizes",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_SideSizes_SizeID",
                table: "SideSizes",
                column: "SizeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ComboDrinkItems");

            migrationBuilder.DropTable(
                name: "ComboSideItems");

            migrationBuilder.DropTable(
                name: "Condiments");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "EntreeAddons");

            migrationBuilder.DropTable(
                name: "EntreeBaseIngredients");

            migrationBuilder.DropTable(
                name: "EntreeSizes");

            migrationBuilder.DropTable(
                name: "ItemAvailableAddons");

            migrationBuilder.DropTable(
                name: "ItemBaseIngredients");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "ItemSizes");

            migrationBuilder.DropTable(
                name: "SelectedEntreeIngredients");

            migrationBuilder.DropTable(
                name: "SelectedSideIngredients");

            migrationBuilder.DropTable(
                name: "SideAddons");

            migrationBuilder.DropTable(
                name: "SideBaseIngredients");

            migrationBuilder.DropTable(
                name: "SideSizes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "SelectedEntrees");

            migrationBuilder.DropTable(
                name: "SelectedSides");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Entrees");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CartItemStatuses");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
