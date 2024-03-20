using F1API.DAOs;
using F1API.Models;
using F1API.Responses;
using F1API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace F1API.Controllers
{
    [Route("f1api/v1/seasons")]
    [ApiController]
    public class SeasonsController : ControllerBase
    {
        private readonly ISeasonsService _seasonsService;
        private readonly SeasonsDAO _seasonDAO;

        /// <summary>
        /// This method shows a summary of all F1 seasons (year, races, countries, 1st race and last race of the season and driver's champion and constructor's champion).
        /// </summary>
        /// <returns>A JSON with all F1 seasons data.</returns>
        /// <response code="200">Sucess.</response>
        /// <response code="404">No season found.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAllSeasons() {
            var result = _seasonsService.GetAllSeasons();

            if(result.StatusCode == 200)
                return Ok(result);

            return NotFound(result);
        }

        /// <summary>
        /// This method searchs for one especific F1 season by the year of the season.
        /// </summary>
        /// <param name="seasonYear">The year of the season (example: 1990).</param>
        /// <returns>The season data (year, races, countries, 1st race and last race of the season and driver's champion and constructor's champion) when the parameter is a valid F1 season year, or will returns 404.</returns>
        /// <response code="200">Sucess.</response>
        /// <response code="400">Invalid parameter.</response>
        /// <response code="404">No season found.</response>
        [HttpGet("{seasonYear}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetSeasonByYear(int seasonYear)
        {
            var result = _seasonsService.GetSeasonByYear(seasonYear);

            if (result.StatusCode == 200)
                return Ok(result);

            if (result.StatusCode == 404)
                return NotFound(result);

            return BadRequest();
        }

        /// <summary>
        /// This method creates a F1 season.
        /// </summary>
        /// <param name="season">A JSON that represents a F1 Season.</param>
        /// <returns>The season data (year, races, countries, 1st race and last race of the season and driver's champion and constructor's champion) of created F1 season, or will returns some error if the parameter is invalid or access is unauthorized.</returns>
        /// <response code="201">Sucess.</response>
        /// <response code="400">If some parameter is invalid.</response>
        /// <response code="401">If the header JWT Bearer token is invalid.</response>
        [HttpPost("create", Name = "create")]
        [Authorize(Roles = "authorized_guess")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Create(Season season)
        {
            var result = _seasonsService.CreateSeason(season);

            if (result.StatusCode == 201)
                return CreatedAtAction(nameof(GetSeasonByYear), new { seasonYear = season.SeasonYear }, result);

            return BadRequest();
        }

        /// <summary>
        /// This method updates a F1 season.
        /// </summary>
        /// <param name="seasonYear">The year of the season (example: 1990).</param>
        /// <param name="season">A JSON that represents a F1 Season.</param>
        /// <response code="204">Sucess.</response>
        /// <response code="401">If the header JWT Bearer token is invalid.</response>
        /// <response code="404">If the parameter seasonYear is invalid.</response>
        /// <returns>Status code 204 for sucess, 401 if access is unauthorized or 404 if the parameter seasonYear is invalid.</returns>
        [HttpPut("{seasonYear}")]
        [Authorize(Roles = "authorized_guess")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update(int seasonYear, Season season)
        {
            var result = _seasonsService.UpdateSeason(seasonYear, season);

            if (result.StatusCode == 404)
                return NotFound(result);

            return NoContent();
        }

        /// <summary>
        /// This method deletes a F1 season.
        /// </summary>
        /// <param name="seasonYear">The year of the season (example: 1990).</param>
        /// <response code="204">Sucess.</response>
        /// <response code="401">If the header JWT Bearer token is invalid.</response>
        /// <response code="404">If the parameter seasonYear is invalid.</response>
        /// <returns>Status code 204 for sucess, 401 if access is unauthorized or 404 if the parameter seasonYear is invalid .</returns>
        [HttpDelete("{seasonYear}")]
        [Authorize(Roles = "authorized_guess")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int seasonYear)
        {
            var result = _seasonsService.DeleteSeason(seasonYear);

            if (result.StatusCode == 404)
                return NotFound(result);

            return NoContent();
        }

        public SeasonsController(SeasonsDAO seasonDAO, ISeasonsService seasonsService)
        {
            _seasonDAO = seasonDAO;
            _seasonsService = seasonsService;
        }
    }
}
