using System.ComponentModel.DataAnnotations;

namespace ScreenSoundAPI.Requests
{
    public record MusicaRequest([Required] string nome, [Required] int ArtistaId, int anoLancamento);
    
}
