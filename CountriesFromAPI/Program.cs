namespace CountriesFromAPI
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            CountryDataService countryDataService = new CountryDataService();
            await countryDataService.GenerateCountryDataFilesAsync();
            Console.WriteLine("Country data files generated.");

        }
    }
}