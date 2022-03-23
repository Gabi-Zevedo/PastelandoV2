using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaPastelando.DAL.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cardapios");

            migrationBuilder.CreateTable(
                name: "Bebidas",
                columns: table => new
                {
                    BebidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebidas", x => x.BebidaId);
                });

            migrationBuilder.CreateTable(
                name: "Complementos",
                columns: table => new
                {
                    ComplementoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    ValorAdicional = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complementos", x => x.ComplementoId);
                });

            migrationBuilder.CreateTable(
                name: "Massas",
                columns: table => new
                {
                    MassaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Massas", x => x.MassaId);
                });

            migrationBuilder.CreateTable(
                name: "OutrosItens",
                columns: table => new
                {
                    OutroItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutrosItens", x => x.OutroItemId);
                });

            migrationBuilder.CreateTable(
                name: "Recheios",
                columns: table => new
                {
                    RecheioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    ValorAdicional = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recheios", x => x.RecheioId);
                });

            migrationBuilder.CreateTable(
                name: "Sobremesas",
                columns: table => new
                {
                    SobremesaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sobremesas", x => x.SobremesaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebidas");

            migrationBuilder.DropTable(
                name: "Complementos");

            migrationBuilder.DropTable(
                name: "Massas");

            migrationBuilder.DropTable(
                name: "OutrosItens");

            migrationBuilder.DropTable(
                name: "Recheios");

            migrationBuilder.DropTable(
                name: "Sobremesas");

            migrationBuilder.CreateTable(
                name: "Cardapios",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    ValorAdicional = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cardapios", x => x.ItemId);
                });
        }
    }
}
