namespace DesignPatterns.SingletonPattern;

public class CountryProvider
{
    private static CountryProvider? instance = null;
    public static CountryProvider Instance => instance ??= new CountryProvider();

    private List<string> Countries { get; set; }

    private CountryProvider()
    {
        Task.Delay(2000).Wait();
        Countries = new List<string>()
        {
            "Tr",
            "Uk",
            "Usa",
        };
    }

    public List<string> GetCountries() => Countries;
}