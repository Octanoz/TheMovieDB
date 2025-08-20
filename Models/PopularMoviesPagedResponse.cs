namespace TheMovieDB.Models;

using System.Text.Json.Serialization;

public class PopularMoviesPagedResponse
{
    public int Page { get; set; }

    public IEnumerable<PopularMovie> Results { get; set; } = [];

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }

}
