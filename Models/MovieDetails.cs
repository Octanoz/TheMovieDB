namespace TheMovieDB.Models;

using System.Text.Json.Serialization;

public class MovieDetails
{
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("belongs_to_collection")]
    public MovieCollection? BelongsToCollection { get; set; }
    public int Budget { get; set; }
    public Genre[] Genres { get; set; } = [];
    public string? Homepage { get; set; }
    public int Id { get; set; }

    [JsonPropertyName("imdb_id")]
    public string? ImdbId { get; set; }

    [JsonPropertyName("origin_country")]
    public string?[] OriginCountry { get; set; } = [];

    [JsonPropertyName("original_language")]
    public string? OriginalLanguage { get; set; }

    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }
    public string? Overview { get; set; }
    public float Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }

    [JsonPropertyName("production_companies")]
    public ProductionCompany[] ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public ProductionCountry[] ProductionCountries { get; set; } = [];

    [JsonPropertyName("release_date")]
    public string? ReleaseDate { get; set; }
    public long Revenue { get; set; }
    public int Runtime { get; set; }

    [JsonPropertyName("spoken_languages")]
    public SpokenLanguage[] SpokenLanguages { get; set; } = [];
    public string? Status { get; set; }
    public string? Tagline { get; set; }
    public string? Title { get; set; }
    public bool Video { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
}

public class Genre
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class ProductionCompany
{
    public int Id { get; set; }

    [JsonPropertyName("logo_path")]
    public string? LogoPath { get; set; }
    public string? Name { get; set; }

    [JsonPropertyName("origin_country")]
    public string? OriginCountry { get; set; }
}

public class ProductionCountry
{
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166Code { get; set; }
    public string? Name { get; set; }
}

public class SpokenLanguage
{
    [JsonPropertyName("english_name")]
    public string? EnglishName { get; set; }

    [JsonPropertyName("iso_639_1")]
    public string? Iso639Code { get; set; }
    public string? Name { get; set; }
}

public class MovieCollection
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }
}
