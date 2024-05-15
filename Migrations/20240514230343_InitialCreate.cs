using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrasesMAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_frasesM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    frase = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    autor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    sentimento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_frasesM", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "TB_frasesM",
                columns: new[] { "ID", "autor", "frase", "sentimento" },
                values: new object[,]
                {
                    { 1, "Donald Trump", "Não deixe que a tristeza atrapalhe seus sonhos e objetivos...", "Tristeza" },
                    { 2, "Charlie Chaplin", "A vida é maravilhosa se não se tem medo dela.", "Medo" },
                    { 3, "Cartola", "A sorrir eu pretendo levar a vida..", "Felicidade" },
                    { 4, "augusto Cury", "Não tenha medo do caminho, tenha medo de não caminhar", "Ansiedade" },
                    { 5, "Bob Marley", "Saudade é um sentimento que, quando não cabe no coração, escorre pelos olhos.", "Saudade" },
                    { 6, "Chico Xavier", "A desilusão é a visita da verdade.", "Decepção" },
                    { 7, "Shakespeare", "A raiva é um veneno que bebemos esperando que os outros morram.", "Raiva" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_frasesM");
        }
    }
}
