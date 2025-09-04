using System.Text.Json;
using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "Travis Scott");


        var musicasPreferidasDoJoao = new MusicasPreferidas("João");
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[690]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[15]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[190]);
        musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[233]);

        musicasPreferidasDoJoao.ExibirMusicasFavoritas();
        musicasPreferidasDoJoao.GerarArquivoJson();

        // var musicasPreferidasDaGeovana = new MusicasPreferidas("Geovana");
        // musicasPreferidasDaGeovana.AdicionarMusicasFavoritas(musicas[1021]);
        // musicasPreferidasDaGeovana.AdicionarMusicasFavoritas(musicas[292]);
        // musicasPreferidasDaGeovana.AdicionarMusicasFavoritas(musicas[267]);
        // musicasPreferidasDaGeovana.AdicionarMusicasFavoritas(musicas[999]);
        // musicasPreferidasDaGeovana.AdicionarMusicasFavoritas(musicas[12]);

        // musicasPreferidasDaGeovana.ExibirMusicasFavoritas();

    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine($"Temos um problema: {ex.Message}");
        throw;
    }
    
}