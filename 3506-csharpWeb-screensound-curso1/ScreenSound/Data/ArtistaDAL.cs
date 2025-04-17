using ScreenSound.Modelos;
using System.Data.SqlClient;


namespace ScreenSound.Data
{
    internal class ArtistaDAL
    {

        public IEnumerable<Artista> Listar()
        {

            using var context = new ScreenSoundContext();

            return context.Artistas.ToList();
            

        }

        //public void Adicionar(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";

        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);

        //    int retorno = command.ExecuteNonQuery();
        //    Console.WriteLine($"Linhas afetadas: {retorno}");

        //}

        //public void Atualizar(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";

        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);

        //    int retorno = command.ExecuteNonQuery();
        //    Console.WriteLine($"Linhas afetadas: {retorno}");
        //}

        //public void Deletar(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = $"DELETE FROM Artistas WHERE Id = @id";

        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@id", artista.Id);

        //    int retorno = command.ExecuteNonQuery();

        //    Console.WriteLine($"Linhas afetadas: {retorno}");
        //}
    }
}
