namespace Exercise_14_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var animals = words.Select(x => new
            {
                Name = x,
                Length = x.Length
            }).OrderBy(x=>x.Length);

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} - {animal.Length} букв");
            }
        }
    }
}
