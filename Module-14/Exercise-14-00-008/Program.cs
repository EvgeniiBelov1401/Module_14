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
            var selectName2=objects.Where(n => n is string).OrderBy(n => n);

            foreach (var obj in selectName2)
            {
                Console.WriteLine(obj);
            }
            #endregion
        }
    }
}
