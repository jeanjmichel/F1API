﻿using F1API.DAOs;
using F1API.Models;
using F1API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace F1API.Controllers
{
    [Route("f1api/v1/seasons")]
    [ApiController]
    public class SeasonsController : ControllerBase
    {

        private readonly SeasonDAO _seasonDAO;

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
            APIResultData res = new APIResultData();
            
            if(_seasonDAO.Seasons.Count > 0)
            {
                res.ReturnedData = _seasonDAO.Seasons;
                res.StatusCode = 200;
                res.StatusMessage = "Ok";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
            }
            else
            {
                res.ReturnedData = null;
                res.StatusCode = 404;
                res.StatusMessage = "No F1 season found.";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
                return NotFound(res);
            }
            
            return Ok(res);
        }

        /// <summary>
        /// This method searchs for one especific F1 season by the year of the season.
        /// </summary>
        /// <param name="seasonYear">Year of the season (example: 1990).</param>
        /// <returns>The season data (year, races, countries, 1st race and last race of the season and driver's champion and constructor's champion) wheen the parameter is a valid F1 season year, or will returns 404.</returns>
        /// <response code="200">Sucess.</response>
        /// <response code="404">No season found.</response>
        [HttpGet("{seasonYear}")]
        public IActionResult GetSeasonByYear(int seasonYear)
        {
            APIResultData res = new APIResultData();

            Season? season = _seasonDAO.Seasons.SingleOrDefault(s => s.SeasonYear == seasonYear);

            if (season != null)
            {
                res.ReturnedData = season;
                res.StatusCode = 200;
                res.StatusMessage = "OK";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
            }
            else
            {
                res.ReturnedData = null;
                res.StatusCode = 404;
                res.StatusMessage = "No F1 season found.";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
                return NotFound(res);
            }

            return Ok(res);
        }

        public SeasonsController(SeasonDAO seasonDAO)
        {
            _seasonDAO = seasonDAO;
        }
    }
}
