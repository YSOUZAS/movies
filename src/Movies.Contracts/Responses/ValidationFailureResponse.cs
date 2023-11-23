namespace Movies.Contracts.Responses;

public readonly record struct ValidationFailureResponse
{
    public IEnumerable<ValidationResponse> Erros { get; init; }
}

