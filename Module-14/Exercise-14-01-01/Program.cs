namespace Exercise_14_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var russianCities = new List<City>();

            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            foreach (var city in russianCities.Where(x=>x.Population>1000000).OrderByDescending(x=>x.Population))
            {
                Console.WriteLine(city.Name+": "+city.Population);
            }
            Console.ReadLine();

            foreach (var city in russianCities.Where(x=>x.Name.Length<=10).OrderBy(x=>x.Name.Length))
            {
                Console.WriteLine(city.Name);
            }
        }
    }
}
