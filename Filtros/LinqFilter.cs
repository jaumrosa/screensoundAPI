using ScreenSoundAPI.Modelos;
namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            System.Console.WriteLine($"-> {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        System.Console.WriteLine($"Exibindo os artista do gênero {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            System.Console.WriteLine($"-> {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).Distinct().ToList();
        System.Console.WriteLine($"Exibindo as músicas de {artista}:");

        foreach (var musica in musicasDoArtista)
        {
            System.Console.WriteLine($" -> {musica}");
        }
    }
}