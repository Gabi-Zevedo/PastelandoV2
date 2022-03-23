using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaPastelando.DAL.Migrations
{
    public partial class BancoPopulado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "BebidaId", "Nome", "Valor" },
                values: new object[,]
                {
                    { 1, "Coca-cola 2L", 9.5 },
                    { 2, "Coca-cola 350ml", 4.5 },
                    { 3, "Coca-cola 600ml", 6.5 },
                    { 4, "Guaravita", 2.5 },
                    { 5, "Guaraná 2L", 8.5 },
                    { 6, "Guaraná 350L", 4.5 }
                });

            migrationBuilder.InsertData(
                table: "Complementos",
                columns: new[] { "ComplementoId", "Nome", "Valor", "ValorAdicional" },
                values: new object[,]
                {
                    { 1, "Cebola", 0.0, 3.0 },
                    { 2, "Tomate", 0.0, 3.0 },
                    { 3, "Cheddar", 0.0, 3.0 },
                    { 4, "Catupiry", 0.0, 3.0 },
                    { 5, "Cream Cheese", 2.0, 3.0 },
                    { 6, "Azeitona", 0.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Massas",
                columns: new[] { "MassaId", "Nome", "Valor" },
                values: new object[,]
                {
                    { 3, "Cacau", 6.5 },
                    { 2, "Pimenta", 4.5 },
                    { 1, "Original", 14.0 }
                });

            migrationBuilder.InsertData(
                table: "OutrosItens",
                columns: new[] { "OutroItemId", "Nome", "Valor" },
                values: new object[] { 1, "Pastel de Vento", 6.0 });

            migrationBuilder.InsertData(
                table: "Recheios",
                columns: new[] { "RecheioId", "Nome", "Valor", "ValorAdicional" },
                values: new object[,]
                {
                    { 1, "Mussarela", 0.0, 3.0 },
                    { 2, "Minas", 0.0, 3.0 },
                    { 3, "Presunto", 0.0, 3.0 },
                    { 4, "Calabresa", 0.0, 3.0 },
                    { 5, "Carne", 2.0, 3.0 },
                    { 6, "Frango", 0.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Sobremesas",
                columns: new[] { "SobremesaId", "Nome", "Valor" },
                values: new object[,]
                {
                    { 1, "Pastel Banana c/ açucar", 8.0 },
                    { 2, "Pastel Romeu e Julieta", 8.0 },
                    { 3, "Pastel de Churros", 8.0 },
                    { 4, "Pastel Banana c/ Nutela", 8.0 },
                    { 5, "Pastel de Ovomaltine", 8.0 },
                    { 6, "Pastel Mineirin", 8.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bebidas",
                keyColumn: "BebidaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bebidas",
                keyColumn: "BebidaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bebidas",
                keyColumn: "BebidaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bebidas",
                keyColumn: "BebidaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bebidas",
                keyColumn: "BebidaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bebidas",
                keyColumn: "BebidaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Complementos",
                keyColumn: "ComplementoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Complementos",
                keyColumn: "ComplementoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Complementos",
                keyColumn: "ComplementoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Complementos",
                keyColumn: "ComplementoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Complementos",
                keyColumn: "ComplementoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Complementos",
                keyColumn: "ComplementoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Massas",
                keyColumn: "MassaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Massas",
                keyColumn: "MassaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Massas",
                keyColumn: "MassaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OutrosItens",
                keyColumn: "OutroItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recheios",
                keyColumn: "RecheioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recheios",
                keyColumn: "RecheioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recheios",
                keyColumn: "RecheioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recheios",
                keyColumn: "RecheioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recheios",
                keyColumn: "RecheioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recheios",
                keyColumn: "RecheioId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sobremesas",
                keyColumn: "SobremesaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sobremesas",
                keyColumn: "SobremesaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sobremesas",
                keyColumn: "SobremesaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sobremesas",
                keyColumn: "SobremesaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sobremesas",
                keyColumn: "SobremesaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sobremesas",
                keyColumn: "SobremesaId",
                keyValue: 6);
        }
    }
}
