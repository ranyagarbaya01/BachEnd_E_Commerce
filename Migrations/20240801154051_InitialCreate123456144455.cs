using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace store.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate123456144455 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItem");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "CustomerBasket");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Zipcode",
                table: "User",
                newName: "MFcin");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "User",
                newName: "Gouvernorat");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "User",
                newName: "CodePostal");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "Adresse");

            migrationBuilder.AddColumn<string>(
                name: "NomRaisonSocial",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Heure",
                table: "Commande",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Commande",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "Commande",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodePostal",
                table: "Commande",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gouvernorat",
                table: "Commande",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MFcin",
                table: "Commande",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomRaisonSocial",
                table: "Commande",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Societe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaisonSocial = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Acitivite = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    MF = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    NumTel = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Rib = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societe", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Societe");

            migrationBuilder.DropColumn(
                name: "NomRaisonSocial",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "CodePostal",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "Gouvernorat",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "MFcin",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "NomRaisonSocial",
                table: "Commande");

            migrationBuilder.RenameColumn(
                name: "MFcin",
                table: "User",
                newName: "Zipcode");

            migrationBuilder.RenameColumn(
                name: "Gouvernorat",
                table: "User",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "CodePostal",
                table: "User",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "User",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Heure",
                table: "Commande",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Commande",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.CreateTable(
                name: "CustomerBasket",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientSecret = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DeliveryMethodId = table.Column<int>(type: "int", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ShippingPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBasket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasketItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CustomerBasketId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItem_CustomerBasket_CustomerBasketId",
                        column: x => x.CustomerBasketId,
                        principalTable: "CustomerBasket",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_CustomerBasketId",
                table: "BasketItem",
                column: "CustomerBasketId");
        }
    }
}
