using System.Text.Json.Serialization;

namespace TheMovieDB;

public class PopularMovie
{
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("genre_ids")]
    public int[] GenreIds { get; set; } = [];

    public int Id { get; set; }

    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; } = String.Empty;

    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }

    public float Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; } = String.Empty;

    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; set; } = String.Empty;

    public string Title { get; set; } = String.Empty;

    public bool Video { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
}
