using ScreenSound.API.Requests;

namespace ScreenSoundAPI.Requests
{
    public record MusicaRequestEdit(int Id, string nome, int ArtistaId, int anoLancamento, ICollection<GeneroRequest> Generos)
     : MusicaRequest(nome, ArtistaId, anoLancamento, Generos);
}
