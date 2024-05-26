namespace Exercise_14_01_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                var numbers = new int[10];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = random.Next(20);
                }

                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
                Console.ReadLine();
                Console.Write("Только четные и только > 10: ");

                foreach (var item in numbers.Where(x=>x%2==0&&x>10))
                {
                    Console.Write(item + " ");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
