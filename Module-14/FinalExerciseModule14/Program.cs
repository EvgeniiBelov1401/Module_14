namespace FinalExerciseModule14
{
    internal class Program
    {
        static char InputChar()
        {
            Console.Write("\nВыберите способ сортировки (1-по возрастанию; 2-по убыванию): ");
            var input=Console.ReadKey().KeyChar;
            Console.WriteLine();
            return input;
        }

        static void Sorting(char input, List<Contact> list)
        {            
            switch (input)
            {
                case '1':
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("По возрастанию:");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    #region логика сортировки по возрастанию через LINQ
                    var sortList=from contact in list
                                 orderby contact.FirstName, contact.LastName
                                 select contact;
                    foreach (var contact in sortList)
                    {
                        Console.WriteLine($"{contact.FirstName} {contact.LastName}: {contact.PhoneNumber} ({contact.Email})");
                    }
                    #endregion

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                    
                case '2':
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("По убыванию:");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;

                    #region логика сортировки по убыванию через методы расширения
                    foreach (var contact in list.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName))
                    {
                        Console.WriteLine($"{contact.FirstName} {contact.LastName}: {contact.PhoneNumber} ({contact.Email})");
                    }
                    #endregion

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                    default:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Выберите верный способ сортировки");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;                    
            }
        }
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            phoneBook.Add(new Contact("Игорь", "Алексеев", 79990240001, "igoral@example.com"));
            phoneBook.Add(new Contact("Сергей", "Панкратов", 79993500010, "sergepan@example.com"));
            phoneBook.Add(new Contact("Антон", "Леонтьев", 79990044012, "anton@example.com"));
            phoneBook.Add(new Contact("Василий", "Карпов", 79990034111, "vasya@example.com"));


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;               
                Console.WriteLine("Контакты. Оригинальный список:");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                foreach (var contact in phoneBook)
                {
                    Console.WriteLine($"{contact.FirstName} {contact.LastName}: {contact.PhoneNumber} ({contact.Email})");
                }
                Console.ForegroundColor = ConsoleColor.White;
                              
                Sorting(InputChar(), phoneBook);

                Console.ReadLine();
                Console.Clear();
            }
           

            

        }
    }
}
