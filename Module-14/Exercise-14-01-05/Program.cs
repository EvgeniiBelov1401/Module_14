namespace Exercise_14_01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            foreach (var company in companies.Where(x=>x.Value.Contains("Mobile")) ) 
            {
               Console.WriteLine(company.Key);
            }
        }
    }
}
