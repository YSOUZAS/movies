namespace Movies.Contracts.Responses;

public readonly record struct ValidationResponse
{
    public required string PropertyName { get; init; }

    public required string Message { get; init; }
}
