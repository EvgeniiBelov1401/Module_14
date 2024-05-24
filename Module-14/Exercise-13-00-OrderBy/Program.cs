namespace Exercise_13_00_OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                var numbers = new List<int>();

                for (int i = 0; i < random.Next(100); i++)
                {
                    numbers.Add(random.Next(100));
                }
                #region OrderBy
                var orderedNumbers = numbers.OrderBy(n => n);

                foreach (var num in orderedNumbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                #endregion

                #region OrderByDescending
                var orderByDesNumbers = numbers.OrderByDescending(n => n);
                foreach (var num in orderByDesNumbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                #endregion

                #region Where
                var evenNumbers = numbers.Where(n => n % 2 == 0);
                foreach (var num in evenNumbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                #endregion

                #region All
                if (numbers.All(n => n < 90))
                {
                    Console.WriteLine("Все элементы меньше 90");
                }
                else
                {
                    Console.WriteLine("Есть элементы, которые >= 90");
                }
                #endregion




                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
