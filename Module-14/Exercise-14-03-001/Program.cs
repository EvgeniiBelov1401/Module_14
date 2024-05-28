namespace Exercise_14_03_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                var list = new List<int>();

                for (int i = 0; i < random.Next(100); i++)
                {
                    list.Add(random.Next(100));
                }
                Console.WriteLine("Коллекция случайных чисел:");
                foreach (var item in list)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();

                
                
                Console.WriteLine("По возрастанию через методы расширения:");
                foreach(var item in list.OrderBy(x=>x))
                {
                Console.Write(item+" "); 
                }
                Console.WriteLine();


                Console.WriteLine("По возрастанию через LINQ:");
                var orderedList=from item in list
                                orderby item
                                select item;
                foreach (var item in orderedList)
                {
                Console.Write(item+" "); 
                }
                Console.WriteLine();


                Console.WriteLine("По убыванию через методы расширения:");
                foreach (var item in list.OrderByDescending(x => x))
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();


                Console.WriteLine("По убыванию через LINQ:");
                var orderedByDesc=from item in list
                                  orderby item descending
                                  select item;
                foreach (var item in orderedByDesc)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
