using F1API.Models;

namespace F1API.DAOs
{
    public class SeasonDAO
    {
        public List<Season> Seasons { get; set; }
        public SeasonDAO() {
            Console.WriteLine("Initializing SeasonDAO instance...");
            Seasons = new List<Season>();
            Console.WriteLine("Populating SeasonDAO.Seasons data...");
            Seasons.Add(new Season(1950, 7, 7, "1950 British Grand Prix", "1950 Italian Grand Prix", "Giuseppe Farina (ITA) (Alfa Romeo)", "Not awarded"));
            Seasons.Add(new Season(1951, 8, 8, "1951 Swiss Grand Prix", "1951 Spanish Grand Prix", "Juan Manuel Fangio (ARG) (Alfa Romeo)", "Not awarded"));
            Seasons.Add(new Season(1952, 8, 8, "1952 Swiss Grand Prix", "1952 Italian Grand Prix", "Alberto Ascari (ITA) (Ferrari)", "Not awarded"));
            Seasons.Add(new Season(1953, 9, 9, "1953 Argentine Grand Prix", "1953 Italian Grand Prix", "Alberto Ascari (ITA) (Ferrari)", "Not awarded"));
            Seasons.Add(new Season(1954, 9, 9, "1954 Argentine Grand Prix", "1954 Spanish Grand Prix", "Juan Manuel Fangio (ARG) (Maserati/Mercedes)", "Not awarded"));
            Seasons.Add(new Season(1955, 7, 7, "1955 Argentine Grand Prix", "1955 Italian Grand Prix", "Juan Manuel Fangio (ARG) (Mercedes)", "Not awarded"));
            Seasons.Add(new Season(1956, 8, 8, "1956 Argentine Grand Prix", "1956 Italian Grand Prix", "Juan Manuel Fangio (ARG) (Ferrari)", "Not awarded"));
            Seasons.Add(new Season(1957, 8, 7, "1957 Argentine Grand Prix", "1957 Italian Grand Prix", "Juan Manuel Fangio (ARG) (Maserati)", "Not awarded"));
            Seasons.Add(new Season(1958, 11, 11, "1958 Argentine Grand Prix", "1958 Moroccan Grand Prix", "Mike Hawthorn (GBR) (Ferrari)", "Vanwall (GBR)"));
            Seasons.Add(new Season(1959, 9, 8, "1959 Monaco Grand Prix", "1959 United States Grand Prix", "Jack Brabham (AUS) (Cooper)", "Cooper-Climax (GBR)"));
            Seasons.Add(new Season(1960, 10, 9, "1960 Argentine Grand Prix", "1960 United States Grand Prix", "Jack Brabham (AUS) (Cooper)", "Cooper-Climax (GBR)"));
            Seasons.Add(new Season(1961, 8, 8, "1961 Monaco Grand Prix", "1961 United States Grand Prix", "Phil Hill (USA) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1962, 9, 9, "1962 Dutch Grand Prix", "1962 South African Grand Prix", "Graham Hill (GBR) (BRM)", "BRM (GBR)"));
            Seasons.Add(new Season(1963, 10, 10, "1963 Monaco Grand Prix", "1963 South African Grand Prix", "Jim Clark (GBR) (Lotus)", "Lotus-Climax (GBR)"));
            Seasons.Add(new Season(1964, 10, 10, "1964 Monaco Grand Prix", "1964 Mexican Grand Prix", "John Surtees (GBR) (Ferrari/NART)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1965, 10, 10, "1965 South African Grand Prix", "1965 Mexican Grand Prix", "Jim Clark (GBR) (Lotus)", "Lotus-Climax (GBR)"));
            Seasons.Add(new Season(1966, 9, 9, "1966 Monaco Grand Prix", "1966 Mexican Grand Prix", "Jack Brabham (AUS) (Brabham)", "Brabham-Repco (GBR)"));
            Seasons.Add(new Season(1967, 11, 11, "1967 South African Grand Prix", "1967 Mexican Grand Prix", "Denny Hulme (NZL) (Brabham)", "Brabham-Repco (GBR)"));
            Seasons.Add(new Season(1968, 12, 12, "1968 South African Grand Prix", "1968 Mexican Grand Prix", "Graham Hill (GBR) (Lotus)", "Lotus-Ford (GBR)"));
            Seasons.Add(new Season(1969, 11, 11, "1969 South African Grand Prix", "1969 Mexican Grand Prix", "Jackie Stewart (GBR) (Matra)", "Matra-Ford (FRA)"));
            Seasons.Add(new Season(1970, 13, 13, "1970 South African Grand Prix", "1970 Mexican Grand Prix", "Jochen Rindt (AUT) (Lotus)", "Lotus-Ford (GBR)"));
            Seasons.Add(new Season(1971, 11, 11, "1971 South African Grand Prix", "1971 United States Grand Prix", "Jackie Stewart (GBR) (Tyrrell)", "Tyrrell-Ford (GBR)"));
            Seasons.Add(new Season(1972, 12, 12, "1972 Argentine Grand Prix", "1972 United States Grand Prix", "Emerson Fittipaldi (BRA) (Lotus)", "Lotus-Ford (GBR)"));
            Seasons.Add(new Season(1973, 15, 15, "1973 Argentine Grand Prix", "1973 United States Grand Prix", "Jackie Stewart (GBR) (Tyrrell)", "Lotus-Ford (GBR)"));
            Seasons.Add(new Season(1974, 15, 15, "1974 Argentine Grand Prix", "1974 United States Grand Prix", "Emerson Fittipaldi (BRA) (McLaren)", "McLaren-Ford (GBR)"));
            Seasons.Add(new Season(1975, 14, 14, "1975 Argentine Grand Prix", "1975 United States Grand Prix", "Niki Lauda (AUT) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1976, 16, 15, "1976 Brazilian Grand Prix", "1976 Japanese Grand Prix", "James Hunt (GBR) (McLaren)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1977, 17, 16, "1977 Argentine Grand Prix", "1977 Japanese Grand Prix", "Niki Lauda (AUT) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1978, 16, 15, "1978 Argentine Grand Prix", "1978 Canadian Grand Prix", "Mario Andretti (USA) (Lotus)", "Lotus-Ford (GBR)"));
            Seasons.Add(new Season(1979, 15, 14, "1979 Argentine Grand Prix", "1979 United States Grand Prix", "Jody Scheckter (RSA) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1980, 14, 13, "1980 Argentine Grand Prix", "1980 United States Grand Prix", "Alan Jones (AUS) (Williams)", "Williams-Ford (GBR)"));
            Seasons.Add(new Season(1981, 15, 13, "1981 United States Grand Prix West", "1981 Caesars Palace Grand Prix", "Nelson Piquet (BRA) (Brabham)", "Williams-Ford (GBR)"));
            Seasons.Add(new Season(1982, 16, 12, "1982 South African Grand Prix", "1982 Caesars Palace Grand Prix", "Keke Rosberg (FIN) (Williams)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1983, 15, 13, "1983 Brazilian Grand Prix", "1983 South African Grand Prix", "Nelson Piquet (BRA) (Brabham)", "Ferrari (ITA)"));
            Seasons.Add(new Season(1984, 16, 14, "1984 Brazilian Grand Prix", "1984 Portuguese Grand Prix", "Niki Lauda (AUT) (McLaren)", "McLaren-TAG (GBR)"));
            Seasons.Add(new Season(1985, 16, 14, "1985 Brazilian Grand Prix", "1985 Australian Grand Prix", "Alain Prost (FRA) (McLaren)", "McLaren-TAG (GBR)"));
            Seasons.Add(new Season(1986, 16, 15, "1986 Brazilian Grand Prix", "1986 Australian Grand Prix", "Alain Prost (FRA) (McLaren)", "Williams-Honda (GBR)"));
            Seasons.Add(new Season(1987, 16, 15, "1987 Brazilian Grand Prix", "1987 Australian Grand Prix", "Nelson Piquet (BRA) (Williams)", "Williams-Honda (GBR)"));
            Seasons.Add(new Season(1988, 16, 15, "1988 Brazilian Grand Prix", "1988 Australian Grand Prix", "Ayrton Senna (BRA) (McLaren)", "McLaren-Honda (GBR)"));
            Seasons.Add(new Season(1989, 16, 15, "1989 Brazilian Grand Prix", "1989 Australian Grand Prix", "Alain Prost (FRA) (McLaren)", "McLaren-Honda (GBR)"));
            Seasons.Add(new Season(1990, 16, 15, "1990 United States Grand Prix", "1990 Australian Grand Prix", "Ayrton Senna (BRA) (McLaren)", "McLaren-Honda (GBR)"));
            Seasons.Add(new Season(1991, 16, 15, "1991 United States Grand Prix", "1991 Australian Grand Prix", "Ayrton Senna (BRA) (McLaren)", "McLaren-Honda (GBR)"));
            Seasons.Add(new Season(1992, 16, 15, "1992 South African Grand Prix", "1992 Australian Grand Prix", "Nigel Mansell (GBR) (Williams)", "Williams-Renault (GBR)"));
            Seasons.Add(new Season(1993, 16, 14, "1993 South African Grand Prix", "1993 Australian Grand Prix", "Alain Prost (FRA) (Williams)", "Williams-Renault (GBR)"));
            Seasons.Add(new Season(1994, 16, 13, "1994 Brazilian Grand Prix", "1994 Australian Grand Prix", "Michael Schumacher (GER) (Benetton)", "Williams-Renault (GBR)"));
            Seasons.Add(new Season(1995, 17, 14, "1995 Brazilian Grand Prix", "1995 Australian Grand Prix", "Michael Schumacher (GER) (Benetton)", "Benetton-Renault (GBR)"));
            Seasons.Add(new Season(1996, 16, 14, "1996 Australian Grand Prix", "1996 Japanese Grand Prix", "Damon Hill (GBR) (Williams)", "Williams-Renault (GBR)"));
            Seasons.Add(new Season(1997, 17, 14, "1997 Australian Grand Prix", "1997 European Grand Prix", "Jacques Villeneuve (CAN) (Williams)", "Williams-Renault (GBR)"));
            Seasons.Add(new Season(1998, 16, 14, "1998 Australian Grand Prix", "1998 Japanese Grand Prix", "Mika Häkkinen (FIN) (McLaren)", "McLaren-Mercedes (GBR)"));
            Seasons.Add(new Season(1999, 16, 14, "1999 Australian Grand Prix", "1999 Japanese Grand Prix", "Mika Häkkinen (FIN) (McLaren)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2000, 17, 15, "2000 Australian Grand Prix", "2000 Malaysian Grand Prix", "Michael Schumacher (GER) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2001, 17, 15, "2001 Australian Grand Prix", "2001 Japanese Grand Prix", "Michael Schumacher (GER) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2002, 17, 15, "2002 Australian Grand Prix", "2002 Japanese Grand Prix", "Michael Schumacher (GER) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2003, 16, 14, "2003 Australian Grand Prix", "2003 Japanese Grand Prix", "Michael Schumacher (GER) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2004, 18, 16, "2004 Australian Grand Prix", "2004 Brazilian Grand Prix", "Michael Schumacher (GER) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2005, 19, 17, "2005 Australian Grand Prix", "2005 Chinese Grand Prix", "Fernando Alonso (ESP) (Renault)", "Renault (FRA)"));
            Seasons.Add(new Season(2006, 18, 16, "2006 Bahrain Grand Prix", "2006 Brazilian Grand Prix", "Fernando Alonso (ESP) (Renault)", "Renault (FRA)"));
            Seasons.Add(new Season(2007, 17, 17, "2007 Australian Grand Prix", "2007 Brazilian Grand Prix", "Kimi Räikkönen (FIN) (Ferrari)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2008, 18, 17, "2008 Australian Grand Prix", "2008 Brazilian Grand Prix", "Lewis Hamilton (GBR) (McLaren)", "Ferrari (ITA)"));
            Seasons.Add(new Season(2009, 17, 16, "2009 Australian Grand Prix", "2009 Abu Dhabi Grand Prix", "Jenson Button (GBR) (Brawn)", "Brawn-Mercedes (GBR)"));
            Seasons.Add(new Season(2010, 19, 18, "2010 Bahrain Grand Prix", "2010 Abu Dhabi Grand Prix", "Sebastian Vettel (GER) (Red Bull)", "Red Bull-Renault (AUT)"));
            Seasons.Add(new Season(2011, 19, 18, "2011 Australian Grand Prix", "2011 Brazilian Grand Prix", "Sebastian Vettel (GER) (Red Bull)", "Red Bull-Renault (AUT)"));
            Seasons.Add(new Season(2012, 20, 19, "2012 Australian Grand Prix", "2012 Brazilian Grand Prix", "Sebastian Vettel (GER) (Red Bull)", "Red Bull-Renault (AUT)"));
            Seasons.Add(new Season(2013, 19, 19, "2013 Australian Grand Prix", "2013 Brazilian Grand Prix", "Sebastian Vettel (GER) (Red Bull)", "Red Bull-Renault (AUT)"));
            Seasons.Add(new Season(2014, 19, 19, "2014 Australian Grand Prix", "2014 Abu Dhabi Grand Prix", "Lewis Hamilton (GBR) (Mercedes)", "Mercedes (GER)"));
            Seasons.Add(new Season(2015, 19, 19, "2015 Australian Grand Prix", "2015 Abu Dhabi Grand Prix", "Lewis Hamilton (GBR) (Mercedes)", "Mercedes (GER)"));
            Seasons.Add(new Season(2016, 21, 21, "2016 Australian Grand Prix", "2016 Abu Dhabi Grand Prix", "Nico Rosberg (GER) (Mercedes)", "Mercedes (GER)"));
            Seasons.Add(new Season(2017, 20, 20, "2017 Australian Grand Prix", "2017 Abu Dhabi Grand Prix", "Lewis Hamilton (GBR) (Mercedes)", "Mercedes (GER)"));
            Seasons.Add(new Season(2018, 21, 21, "2018 Australian Grand Prix", "2018 Abu Dhabi Grand Prix", "Lewis Hamilton (GBR) (Mercedes)", "Mercedes (GER)"));
            Seasons.Add(new Season(2019, 21, 21, "2019 Australian Grand Prix", "2019 Abu Dhabi Grand Prix", "Lewis Hamilton (GBR) (Mercedes)", "Mercedes (GER)"));
            Seasons.Add(new Season(2020, 17, 12, "2020 Austrian Grand Prix", "2020 Abu Dhabi Grand Prix", "Lewis Hamilton (GBR) (Mercedes)", "Mercedes (GER)"));
            Seasons.Add(new Season(2021, 22, 20, "2021 Bahrain Grand Prix", "2021 Abu Dhabi Grand Prix", "Max Verstappen (NED) (Red Bull)", "Mercedes (GER)"));
            Seasons.Add(new Season(2022, 22, 20, "2022 Bahrain Grand Prix", "2022 Abu Dhabi Grand Prix", "Max Verstappen (NED) (Red Bull)", "Red Bull-RBPT (AUT)"));
            Seasons.Add(new Season(2023, 22, 20, "2023 Bahrain Grand Prix", "2023 Abu Dhabi Grand Prix", "Max Verstappen (NED) (Red Bull)", "Red Bull-Honda RBPT (AUT)"));
            Console.WriteLine("Initialized SeasonDAO.");
        }
    
        public Season UpdateSeasonData(Season season)
        {
            Season? _season = this.Seasons.SingleOrDefault(s => s.SeasonYear == season.SeasonYear);

            _season.Races = season.Races;
            _season.Countries = season.Countries;
            _season.FirstRace = season.FirstRace;
            _season.LastRace = season.LastRace;
            _season.DriversChampion = season.DriversChampion;
            _season.ConstructorsChampion = season.ConstructorsChampion;

            return _season;
        }

        public void DeleteSeasonData(int seasonYear)
        {
            Season? _season = this.Seasons.SingleOrDefault(s => s.SeasonYear == seasonYear);
            var isDeleted = this.Seasons.Remove(_season);
        }
    }
}
