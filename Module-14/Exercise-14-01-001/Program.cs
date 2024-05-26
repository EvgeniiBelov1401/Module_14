namespace Exercise_14_01_001
{
    internal class Program
    {
        static void ShowList(List<int>list)
        {
            foreach (int item in list)
            {
                Console.Write(item+" ");
            }
        }

        static void OnlyEvenNumbers(List<int> list)
        {
            foreach (int item in list.Where(x=>x>0).OrderBy(x=>x))
            {

                Console.Write(item + " ");
            }
        }

        static void OnlyNegativeNumbers(List<int> list)
        {
            foreach(var item in list.Where(x => x < 0).OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                var numbers = new List<int>();

                for (int i = 0; i < 100; i++)
                {
                    numbers.Add(random.Next(-100, 100));
                }

                ShowList(numbers);

                Console.WriteLine("\nТолько положительные:");
                OnlyEvenNumbers(numbers);
                Console.WriteLine("\nТолько отрицательные: :");
                OnlyNegativeNumbers(numbers);


                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
