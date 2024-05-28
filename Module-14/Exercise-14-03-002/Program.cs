namespace Exercise_14_03_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                var journal = new List<Students>();
                journal.Add(new Students("Ирина", random.Next(18, 30)));
                journal.Add(new Students("Евгений", random.Next(18, 30)));
                journal.Add(new Students("Алексей", random.Next(18, 30)));
                journal.Add(new Students("Иван", random.Next(18, 30)));
                journal.Add(new Students("Петр", random.Next(18, 30)));
                journal.Add(new Students("Алиса", random.Next(18, 30)));
                journal.Add(new Students("Алексей", random.Next(18, 30)));
                journal.Add(new Students("Юлия", random.Next(18, 30)));
                journal.Add(new Students("Ирина", random.Next(18, 30)));
                journal.Add(new Students("Полина", random.Next(18, 30)));

                Console.WriteLine("Неотсортированный журнал:");
                foreach (var student in journal)
                {
                    Console.WriteLine(student.Name+"  -  "+student.Age);
                }
                Console.WriteLine();


                Console.WriteLine("Отсортированный по возрастанию журнал:");
                foreach(var student in journal.OrderBy(x=>x.Name).ThenBy(x=>x.Age))
                {
                    Console.WriteLine(student.Name + "  -  " + student.Age);
                }
                Console.WriteLine();

                Console.WriteLine("Отсортированный по возрастанию через LINQ журнал:");
                var orderedJournal=from student in journal
                                   orderby student.Name,student.Age                                  
                                   select student;
                foreach (var student in orderedJournal)
                {
                    Console.WriteLine(student.Name + "  -  " + student.Age);
                }
                Console.WriteLine();

                Console.WriteLine("Отсортированный по убыванию журнал:");
                foreach(var student in journal.OrderByDescending(x => x.Name).ThenByDescending(x => x.Age))
                {
                    Console.WriteLine(student.Name + "  -  " + student.Age);
                }
                Console.WriteLine();

                Console.WriteLine("Отсортированный по убыванию через LINQ журнал:");
                var orderedByDescJournal=from student in journal
                                         orderby student.Name, student.Age descending
                                         select student;
                foreach (var student in orderedByDescJournal)
                {
                    Console.WriteLine(student.Name + "  -  " + student.Age);
                }
                Console.WriteLine();

                Console.ReadLine();
                journal=null;
                Console.Clear();
                Console.ReadLine();
            }
           
        }
    }
}
