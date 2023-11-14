namespace Movies.Contracts.Responses;

public readonly record struct MovieResponse
{
    public MovieResponse(Guid id, string title, int yearOfRelease, IEnumerable<string> genres)
    {
        Id = id;
        Title = title;
        YearOfRelease = yearOfRelease;
        Genres = genres;
    }

    public required Guid Id { get; init; }

    public required string Title { get; init; }

    public required int YearOfRelease { get; init; }

    public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
}
