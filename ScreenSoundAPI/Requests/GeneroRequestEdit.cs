namespace ScreenSoundAPI.Requests
{
    public record GeneroRequestEdit(int Id, string nome, string Descricao) : GeneroRequest(nome, Descricao);
}
