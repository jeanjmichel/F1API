using F1API.Models;
using F1API.Responses;

namespace F1API.Services
{
    public interface ISeasonsService
    {
        APIResultData CreateSeason(Season season);
        APIResultData DeleteSeason(int seasonYear);
        APIResultData GetAllSeasons();
        APIResultData GetSeasonByYear(int seasonYear);
        APIResultData UpdateSeason(int seasonYear, Season season);
    }
}