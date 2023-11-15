namespace Movies.Contracts.Requests;

public readonly record struct UpdateMovieRequest
{
    public UpdateMovieRequest(string title, int yearOfRelease, IEnumerable<string> genres)
    {
        Title = title;
        YearOfRelease = yearOfRelease;
        Genres = genres;
    }

    public required string Title { get; init; }

    public required int YearOfRelease { get; init; }

    public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
}