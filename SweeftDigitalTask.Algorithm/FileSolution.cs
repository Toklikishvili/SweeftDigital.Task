using SweeftDigital.Domain;
using System.Text.Json;

namespace SweeftDigital.TaskSolution
{
    static class FileSolution
    {
        public static async Task GenerateCountryDataFiles()
        {
            string apiUrl = "https://restcountries.com/v3.1/all";
            string countriesData;
            using (var client = new HttpClient())
            {
                countriesData = await client.GetStringAsync(apiUrl);
            }
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var countries = JsonSerializer.Deserialize<Country[]>(countriesData, options);

            string directory = "CountryData";
            Directory.CreateDirectory(directory);
            foreach (var country in countries)
            {
                string filename = $"{directory}/{country.Region}.txt";
                using (var writer = new StreamWriter(filename))
                {
                    writer.WriteLine($"Region: {country.Region}");
                    writer.WriteLine($"Subregion: {country.Subregion}");
                    writer.WriteLine($"Latitude, Longitude: {string.Join(", ", country.Latlng)}");
                    writer.WriteLine($"Area: {country.Area} km²");
                    writer.WriteLine($"Population: {country.Population}");
                }
            }
        }

    }
}
