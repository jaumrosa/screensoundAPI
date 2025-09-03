using System.Text.Json;
using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
    
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine($"Temos um problema: {ex.Message}");
        throw;
    }
    
}