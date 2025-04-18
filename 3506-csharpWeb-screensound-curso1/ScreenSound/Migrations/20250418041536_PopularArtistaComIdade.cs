using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularArtistaComIdade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil", "Idade" }, new object[]
            {
             "Justin Bieber", "Justin Drew Bieber é um cantor, compositor e ator canadense.",
                "https://mjbeats.com.br/wp-content/uploads/2023/06/Bart-Simpson-e-Michael-Jackson-thriller-MJ-Beats.jpg",
                31
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas WHERE Nome = 'Justin Bieber'");
        }
    }
}
