

using DesignPatterns.SingletonPattern;

Console.WriteLine(DateTime.Now.ToLongTimeString());

var countries = CountryProvider.Instance.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine(country);
}
Console.WriteLine(countries.Count);
Console.WriteLine("----------------------------");

//Another Service

var anotherCountries = CountryProvider.Instance.GetCountries();
Console.WriteLine(anotherCountries.Count);

Console.WriteLine(DateTime.Now.ToLongTimeString());
