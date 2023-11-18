namespace Movies.Contracts.Responses;

public readonly record struct MovieResponse
{
    public MovieResponse(Guid id, string title, string slug, int yearOfRelease, IEnumerable<string> genres)
    {
        Id = id;
        Title = title;
        YearOfRelease = yearOfRelease;
        Genres = genres;
        Slug = slug;
    }

    public required Guid Id { get; init; }

    public required string Title { get; init; }

    public required string Slug { get; init; }

    public required int YearOfRelease { get; init; }

    public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
}
