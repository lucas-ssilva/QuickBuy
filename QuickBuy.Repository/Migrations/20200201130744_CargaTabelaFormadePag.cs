using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repository.Migrations
{
    public partial class CargaTabelaFormadePag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormaPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "Forma de pagamento boleto", "Boleto" });

            migrationBuilder.InsertData(
                table: "FormaPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Forma de pagamento cartão de credito", "Credito" });

            migrationBuilder.InsertData(
                table: "FormaPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 3, "Forma de pagamento Deposito", "Deposito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
