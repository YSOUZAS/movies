using Microsoft.AspNetCore.Mvc;
using Movies.API.Mapping;
using Movies.Application.Repositories.Interfaces;
using Movies.Contracts.Requests;

namespace Movies.API.Controllers;

[ApiController]
[Route("api")]
public class MoviesController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public MoviesController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpPost("movies")]
    public async Task<IActionResult> Create([FromBody] CreateMovieRequest request)
    {
        var movie = request.MapToMovie();
        await _movieRepository.CreateAsync(movie);

        return Created($"/api/movies/{movie.Id}", movie);
    }
}
