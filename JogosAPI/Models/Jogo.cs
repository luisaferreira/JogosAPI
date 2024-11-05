namespace JogosAPI.Models
{
    public class Jogo
    {
        public string Titulo { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
    
        public Jogo(string titulo, DateTime dataLancamento, string genero)
        {
            Titulo = titulo;
            DataLancamento = dataLancamento;
            Genero = genero;
        }
    }
}
