namespace F1API.Models
{
    public class Season
    {
        public int SeasonYear { get; set; }
        public int Races { get; set; }
        public int Countries { get; set; }
        public string FirstRace { get; set; }
        public string LastRace { get; set; }
        public string DriversChampion { get; set; }
        public string ConstructorsChampion { get; set; }

        public Season(int seasonYear, int races, int countries, string firstRace, string lastRace, 
                      string driversChampion, string constructorsChampion) { 
            this.SeasonYear = seasonYear;
            this.Races = races;
            this.Countries = countries;
            this.FirstRace = firstRace;
            this.LastRace = lastRace;
            this.DriversChampion = driversChampion;
            this.ConstructorsChampion = constructorsChampion;
        }
    }
}
