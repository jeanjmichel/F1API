using F1API.DAOs;
using F1API.Models;
using F1API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace F1API.Services
{
    public class SeasonsService : ISeasonsService
    {

        private readonly SeasonsDAO _seasonDAO;
        public SeasonsService(SeasonsDAO seasonDAO)
        {
            _seasonDAO = seasonDAO;
        }

        public APIResultData GetAllSeasons()
        {
            APIResultData res = new APIResultData();

            if (_seasonDAO.Seasons.Count > 0)
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
            }

            return res;
        }

        public APIResultData GetSeasonByYear(int seasonYear)
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
                res.StatusMessage = "The F1 season not found.";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
            }

            return res;
        }

        public APIResultData CreateSeason(Season season)
        {
            APIResultData res = new APIResultData();

            _seasonDAO.Seasons.Add(season);
            res.ReturnedData = season;
            res.StatusCode = 201;
            res.StatusMessage = "Season added.";
            res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";

            return res;
        }

        public APIResultData UpdateSeason(int seasonYear, Season season)
        {
            APIResultData res = new APIResultData();

            Season? _season = _seasonDAO.Seasons.SingleOrDefault(s => s.SeasonYear == seasonYear);

            if (_season == null)
            {
                res.ReturnedData = null;
                res.StatusCode = 404;
                res.StatusMessage = "The F1 season not found.";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
            }
            else
            {
                _seasonDAO.UpdateSeasonData(seasonYear, season);
            }

            return res;
        }

        public APIResultData DeleteSeason(int seasonYear)
        {
            APIResultData res = new APIResultData();

            Season? _season = _seasonDAO.Seasons.SingleOrDefault(s => s.SeasonYear == seasonYear);

            if (_season == null)
            {
                res.ReturnedData = null;
                res.StatusCode = 404;
                res.StatusMessage = "The F1 season not found.";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
            }
            else
            {
                _seasonDAO.DeleteSeasonData(seasonYear);
            }

            return res;
        }

    }
}
