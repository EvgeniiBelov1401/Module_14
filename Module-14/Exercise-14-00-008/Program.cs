namespace Exercise_14_00_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
               1,
               "Сергей ",
               "Андрей ",
               300,
            };
            #region выражения LINQ
            var selectName = (from n in objects
                              where n is string
                              orderby n
                              select n);

            foreach (var obj in selectName)
            {
                Console.WriteLine(obj);
            }
            #endregion

            #region методы-расширения
            

            foreach (var obj in objects.Where(n => n is string).OrderBy(n => n))
            {
                Console.WriteLine(obj);
            }
            #endregion
        }
    }
}
