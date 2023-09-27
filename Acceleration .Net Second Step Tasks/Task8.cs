using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Acceleration_.Net_Second_Step_Tasks
{
    public static class Task8
    {
        public static async Task GenerateCountryDataFilesAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string url = "https://restcountries.com/v3.1/all";
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Failed to get the data...");
                    return;
                }

                string jsonData = await response.Content.ReadAsStringAsync();
                JArray countries = JArray.Parse(jsonData);

                string directoryPath = "country_data";
                Directory.CreateDirectory(directoryPath);

                foreach (var country in countries)
                {
                    string countryName = country["name"]["common"]?.ToString() ?? "Missing";
                    string fileName = Path.Combine(directoryPath, $"{countryName}.txt");
                    string region = country["region"]?.ToString() ?? "Missing";
                    string subregion = country["subregion"]?.ToString() ?? "Missing";
                    string latlng = string.Join(", ", country["latlng"]?.ToObject<double[]>() ?? new double[] { double.NaN, double.NaN });
                    string area = country["area"]?.ToString() ?? "Missing";
                    string population = country["population"]?.ToString() ?? "Missing";

                    using (StreamWriter myWriter = new StreamWriter(fileName))
                    {
                        myWriter.WriteLine($"region: {region}");
                        myWriter.WriteLine($"subregion: {subregion}");
                        myWriter.WriteLine($"latlng: {latlng}");
                        myWriter.WriteLine($"area: {area}");
                        myWriter.WriteLine($"population: {population}");
                    }
                }
            }

            Console.WriteLine("Foulder with text files, containing info for each country, created!");

        }
    }
}
