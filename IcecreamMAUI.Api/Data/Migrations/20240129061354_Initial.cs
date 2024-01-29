using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IcecreamMAUI.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Icecreams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icecreams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Hash = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IcecreamOptions",
                columns: table => new
                {
                    IcecreamId = table.Column<int>(type: "int", nullable: false),
                    Flavor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Topping = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcecreamOptions", x => new { x.IcecreamId, x.Flavor, x.Topping });
                    table.ForeignKey(
                        name: "FK_IcecreamOptions_Icecreams_IcecreamId",
                        column: x => x.IcecreamId,
                        principalTable: "Icecreams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    IcecreamId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Flavor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Topping = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Icecreams",
                columns: new[] { "Id", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_0.jpg", "Vanilla Delight", 6.25 },
                    { 2, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_1.jpg", "ChocoBerry Bliss", 7.5 },
                    { 3, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_2.jpg", "Minty Cookie Crunch", 8.75 },
                    { 4, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_3.jpg", "Strawberry Dream", 6.9500000000000002 },
                    { 5, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_4.jpg", "Cookie Dough Extravaganza", 9.1999999999999993 },
                    { 6, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_5.jpg", "Caramel Swirl Symphony", 7.75 },
                    { 7, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_6.jpg", "Peanut Butter Paradise", 8.5 },
                    { 8, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_7.jpg", "Mango Tango Tango", 9.8000000000000007 },
                    { 9, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_8.jpg", "Hazelnut Heaven", 8.9499999999999993 },
                    { 10, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_9.jpg", "Blueberry Bliss Bonanza", 7.2000000000000002 },
                    { 11, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_10.jpg", "Toffee Twist Temptation", 7.9500000000000002 },
                    { 12, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_11.jpg", "Rocky Road Revelry", 9.5 },
                    { 13, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_12.jpg", "Passionfruit Paradise", 8.75 },
                    { 14, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_13.jpg", "Cotton Candy Carnival", 7.2000000000000002 },
                    { 15, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_14.jpg", "Lemon Sorbet Serenity", 6.9000000000000004 },
                    { 16, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_15.jpg", "Maple Pecan Pleasure", 8.25 },
                    { 17, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_16.jpg", "Raspberry Ripple Rhapsody", 7.4500000000000002 },
                    { 18, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_17.jpg", "Almond Joyful Jubilee", 9.9499999999999993 },
                    { 19, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_18.jpg", "Blue Lagoon Bliss", 8.5 },
                    { 20, "https://raw.githubusercontent.com/Abhayprince/Images-Icons/main/Icecreams/small/ic_19.jpg", "Coconut Caramel Carnival", 7.7999999999999998 }
                });

            migrationBuilder.InsertData(
                table: "IcecreamOptions",
                columns: new[] { "Flavor", "IcecreamId", "Topping" },
                values: new object[,]
                {
                    { "Default", 1, "Chocolate Sauce" },
                    { "Default", 1, "Whipped Cream" },
                    { "Vanilla", 1, "Default" },
                    { "Chocolate", 2, "Default" },
                    { "Default", 2, "Sprinkles" },
                    { "Strawberry", 2, "Default" },
                    { "Default", 3, "Cherries" },
                    { "Default", 3, "Chocolate Sauce" },
                    { "Mint Chocolate Chip", 3, "Default" },
                    { "Default", 4, "Sprinkles" },
                    { "Default", 4, "Whipped Cream" },
                    { "Strawberry", 4, "Default" },
                    { "Cookie Dough", 5, "Default" },
                    { "Default", 5, "Cherries" },
                    { "Default", 5, "Chocolate Sauce" },
                    { "Default", 6, "Cherries" },
                    { "Default", 6, "Chocolate Sauce" },
                    { "Vanilla", 6, "Default" },
                    { "Chocolate", 7, "Default" },
                    { "Default", 7, "Sprinkles" },
                    { "Default", 7, "Whipped Cream" },
                    { "Cookie Dough", 8, "Default" },
                    { "Default", 8, "Sprinkles" },
                    { "Strawberry", 8, "Default" },
                    { "Default", 9, "Chocolate Sauce" },
                    { "Default", 9, "Whipped Cream" },
                    { "Mint Chocolate Chip", 9, "Default" },
                    { "Chocolate", 10, "Default" },
                    { "Default", 10, "Cherries" },
                    { "Strawberry", 10, "Default" },
                    { "Default", 11, "Cherries" },
                    { "Default", 11, "Whipped Cream" },
                    { "Vanilla", 11, "Default" },
                    { "Chocolate", 12, "Default" },
                    { "Default", 12, "Chocolate Sauce" },
                    { "Mint Chocolate Chip", 12, "Default" },
                    { "Default", 13, "Sprinkles" },
                    { "Default", 13, "Whipped Cream" },
                    { "Strawberry", 13, "Default" },
                    { "Cookie Dough", 14, "Default" },
                    { "Default", 14, "Cherries" },
                    { "Default", 14, "Chocolate Sauce" },
                    { "Default", 15, "Sprinkles" },
                    { "Strawberry", 15, "Default" },
                    { "Vanilla", 15, "Default" },
                    { "Chocolate", 16, "Default" },
                    { "Default", 16, "Whipped Cream" },
                    { "Mint Chocolate Chip", 16, "Default" },
                    { "Cookie Dough", 17, "Default" },
                    { "Default", 17, "Chocolate Sauce" },
                    { "Strawberry", 17, "Default" },
                    { "Default", 18, "Cherries" },
                    { "Default", 18, "Sprinkles" },
                    { "Vanilla", 18, "Default" },
                    { "Chocolate", 19, "Default" },
                    { "Default", 19, "Whipped Cream" },
                    { "Strawberry", 19, "Default" },
                    { "Default", 20, "Chocolate Sauce" },
                    { "Default", 20, "Sprinkles" },
                    { "Mint Chocolate Chip", 20, "Default" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IcecreamOptions");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Icecreams");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
