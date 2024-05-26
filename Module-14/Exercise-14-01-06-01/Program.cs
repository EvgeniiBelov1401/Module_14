namespace Exercise_14_01_06_01
{
    internal class Program
    {
        static int[] FillArray()
        {
            Random rnd = new Random();
            var array= new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }
            return array;
        }
        static void Main(string[] args)
        {
           while (true)
            {
                var numberList = new List<int[]>();

                numberList.Add(FillArray());
                numberList.Add(FillArray());
                numberList.Add(FillArray());

                foreach (var number in numberList)
                {
                    foreach (var item in number)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
                Console.WriteLine("Четные по возрастанию:");
                foreach (var item in numberList.SelectMany(x=>x).Where(x=>x%2==0).OrderBy(x=>x))
                {
                    Console.Write(item + " ");
                }


                Console.ReadLine();
                Console.WriteLine("Нечетные по убыванию:");
                var nonEvenNumbers=from x in numberList
                                   from y in x
                                   where y%2!=0
                                   orderby y descending
                                   select y;
                foreach (var x in nonEvenNumbers)
                {
                Console.Write(x + " "); 
                }




                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
