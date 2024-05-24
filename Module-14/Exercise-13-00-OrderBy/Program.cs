namespace Exercise_13_00_OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var numbers=new List<int>();

            for(int i = 0; i < random.Next(100); i++)
            {
                numbers.Add(random.Next(100));
            }

            var orderedNumbers = numbers.OrderBy(n => n);

            foreach(var num  in orderedNumbers)
            {
                Console.Write(num+" ");
            }
        }
    }
}
