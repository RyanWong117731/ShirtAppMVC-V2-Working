using Microsoft.EntityFrameworkCore.Migrations;

namespace ShirtAppMVC.Data.Migrations
{
    public partial class AddAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shirt",
                columns: table => new
                {
                    ShirtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShirtName = table.Column<string>(nullable: false),
                    FilePath = table.Column<string>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Size = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shirt", x => x.ShirtID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShirtID = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    ShippingAdress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Shirt_ShirtID",
                        column: x => x.ShirtID,
                        principalTable: "Shirt",
                        principalColumn: "ShirtID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ShirtID",
                table: "Transaction",
                column: "ShirtID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Shirt");
        }
    }
}
