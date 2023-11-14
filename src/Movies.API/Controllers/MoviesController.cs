using Microsoft.AspNetCore.Mvc;
using Movies.API.Config;
using Movies.API.Mapping;
using Movies.Application.Repositories.Interfaces;
using Movies.Contracts.Requests;

namespace Movies.API.Controllers;

[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public MoviesController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpPost(ApiEndpoints.Movies.Create)]
    public async Task<IActionResult> Create([FromBody] CreateMovieRequest request)
    {
        var movie = request.MapToMovie();
        await _movieRepository.CreateAsync(movie);

        return Created($"/{ApiEndpoints.Movies.Create}/{movie.Id}", movie);
    }
}
