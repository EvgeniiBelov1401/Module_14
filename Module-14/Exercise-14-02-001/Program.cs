namespace Exercise_14_02_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new[] { "Volvo", "Opel", "Suzuki", "Toyota", "Lada", "Kamaz" };

            var carsSkip=cars.Skip(2);

            foreach(var car in carsSkip)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            var carsTake=cars.Take(2);

            foreach (var car in carsTake)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            var carsSkipTake=cars.Skip(2).Take(2);

            foreach ( var car in carsSkipTake)
            {
                Console.WriteLine(car);
            }
        }
    }
}
