using ScreenSound.Modelos;
using System.Data.SqlClient;


namespace ScreenSound.Data
{
    internal class ArtistaDAL
    {

        private readonly ScreenSoundContext context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<Artista> Listar()
        {
            return context.Artistas.ToList();   
        }

        public void Adicionar(Artista artista)
        {
            context.Add(artista);
            context.SaveChanges();
        }

        public void Atualizar(Artista artista)
        {
            context.Update(artista);
            context.SaveChanges();
        }

        public void Deletar(Artista artista)
        {
            context.Remove(artista);
            context.SaveChanges();
        }

        public Artista? RecuperarPeloNome(string nome)
        {
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
        }
    }
}
