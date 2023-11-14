namespace Movies.Contracts.Responses;

public readonly record struct MoviesResponse
{
    public MoviesResponse(IEnumerable<MovieResponse> items)
    {
        Items = items;
    }

    public IEnumerable<MovieResponse> Items { get; init; } = Enumerable.Empty<MovieResponse>();
}
