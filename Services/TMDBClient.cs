namespace TheMovieDB.Services;

using TheMovieDB.Models;
using System.Net.Http.Json;

public class TMDBClient
{
    private readonly HttpClient httpClient;

    public TMDBClient(HttpClient client, IConfiguration config)
    {
        httpClient = client;
        httpClient.BaseAddress = new("https://api.themoviedb.org/3/");
        httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));

        string apiKey = config["TMDBKey"] ?? throw new InvalidDataException("TMDBKey not found");
        httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
    }

    public Task<PopularMoviesPagedResponse?> GetPopularMoviesPagedResponseAsync() => httpClient.GetFromJsonAsync<PopularMoviesPagedResponse>("movie/popular");

    public Task<MovieDetails?> GetMovieDetailsAsync(int id) => httpClient.GetFromJsonAsync<MovieDetails>($"movie/{id}");
}
