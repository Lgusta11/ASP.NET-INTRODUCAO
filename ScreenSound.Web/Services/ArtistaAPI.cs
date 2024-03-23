// ArtistasAPI.cs
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Services
{
    public class ArtistasAPI
    {
        private readonly HttpClient _httpClient;

        public ArtistasAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ArtistaResponse>?> GetArtistasAsync()
        {
            try
            {
                var artistas = await _httpClient.GetFromJsonAsync<List<ArtistaResponse>>("Artistas");

                if (artistas != null && artistas.Count > 0)
                {
                    Console.WriteLine("Artistas obtidos com sucesso:");
                    foreach (var artista in artistas)
                    {
                        Console.WriteLine($"Nome: {artista.Nome}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum artista encontrado na resposta da API.");
                }

                return artistas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter artistas da API: {ex.Message}");
                return null;
            }
        }
    }
}
