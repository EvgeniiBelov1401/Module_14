namespace Exercise_14_01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
               new[] {2, 3, 7, 1},
               new[] {45, 17, 88, 0},
               new[] {23, 32, 44, -6},
            };

            //var orderedList = numsList.SelectMany(s => s).OrderBy(s => s);

            foreach (var item in numsList.SelectMany(s => s).OrderBy(s => s))
                Console.WriteLine(item);
        }
    }
}
