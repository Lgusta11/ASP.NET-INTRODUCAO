using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.Modelos;

public class Musica
{
    private string tituloDaMusica;

    public Musica()
    {

    }

    public Musica(string tituloDaMusica)
    {
        this.tituloDaMusica = tituloDaMusica;
    }

    public Musica(string nome, int anoLancamento, int artistaId)
    {
        Nome = nome;
        AnoLancamento = anoLancamento;
        ArtistaId = artistaId;
    }
    public string Nome { get; set; }
    public int Id { get; set; }
    public int? AnoLancamento { get; set; }
    public int? ArtistaId { get; set; }
    public virtual Artista? Artista { get; set; }
    public virtual ICollection<Genero> Generos { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");

    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";

    }
}