using ScreenSound.Modelos;


namespace ScreenSound.Data
{
    internal class ArtistaDAL: DAL<Artista>
    {
        public ArtistaDAL(ScreenSoundContext context): base(context) { }
    
        public Artista? RecuperarPeloNome(string nome)
        {
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
        }
    }
}
