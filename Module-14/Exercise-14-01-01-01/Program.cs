namespace Exercise_14_01_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Countries=new Dictionary<string, List<City>>();
            var RussianCities=new List<City>();
            var BelarusCities=new List<City>();
            var AmericanCities =new List<City>();

            RussianCities.Add(new City("Москва", 11900000));
            RussianCities.Add(new City("Санкт-Петербург", 4991000));
            RussianCities.Add(new City("Волгоград", 1099000));
            RussianCities.Add(new City("Казань", 1169000));
            RussianCities.Add(new City("Севастополь", 449138));
            Countries.Add("Россия",RussianCities);


            BelarusCities.Add(new City("Минск", 1200000));
            BelarusCities.Add(new City("Витебск", 362466));
            BelarusCities.Add(new City("Гродно", 368710));
            Countries.Add("Беларусь", BelarusCities);


            AmericanCities.Add(new City("Нью-Йорк", 8399000));
            AmericanCities.Add(new City("Вашингтон", 705749));
            AmericanCities.Add(new City("Альбукерке", 560218));
            Countries.Add("США", AmericanCities);


            foreach (var country in Countries)
            {
                foreach (var city in country.Value.Where(x=>x.Population>1000000).OrderByDescending(x=>x.Population))
                {
                    Console.WriteLine(city.Name+": "+city.Population);
                }
            }

            Console.WriteLine();
            Console.ReadLine();
            var millionCity=from country in Countries
                            from city in country.Value
                            where city.Population >1000000
                            orderby city.Population descending
                            select city;
            foreach (var city in millionCity)
            {
                Console.WriteLine(city.Name + ": " + city.Population);
            }
        }
    }
}
