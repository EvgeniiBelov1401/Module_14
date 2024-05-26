namespace Exercise_14_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три", "четыре пять шесть","семь восемь девять" };

            var words = from item in text
                        from word in item.Split(' ')
                        select word;
            
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.ReadLine();

            foreach (var item in text)
            {
                foreach (var word in item.Split(' '))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
