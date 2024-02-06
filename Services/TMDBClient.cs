using System.Net.Http.Json;

namespace TheMovieDB.Services;

public class TMDBClient
{
    private readonly HttpClient _httpClient;

    public TMDBClient(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new("https://api.themoviedb.org/3/");
        _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));

        string apiKey = config["TMDBKey"] ?? throw new InvalidDataException("TMDBKey not found");
        _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
    }

    public Task<PopularMoviesPagedResponse?> GetPopularMoviesPagedResponseAsync()
    {
        return _httpClient.GetFromJsonAsync<PopularMoviesPagedResponse>("movie/popular");
    }
}
