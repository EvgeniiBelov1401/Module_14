namespace Exercise_14_02_10
{
    internal class Program
    {
        static List<Contact> ChoosePage(List<Contact> list)
        {
            Console.Write("Введите номер страницы: ");
            var inputPage = Console.ReadKey().KeyChar;
            List<Contact> page = null;

            switch (inputPage)
            {
                case '1':
                    page = list.Take(2).ToList();
                    break;
                case '2':
                    page = list.Skip(2).Take(2).ToList();
                    break;
                case '3':
                    page = list.Skip(4).ToList();
                    break;
                default:
                    page = null;
                    break;
            }
            return page;
        }

        static void ShowPage(List<Contact> list)
        {
            if (list != null)
            {
                Console.WriteLine();
                foreach (var contact in list)
                {
                    Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber + " (" + contact.Email + ")");
                }
            }
            else
            {
                Console.WriteLine("\nCтраницы не существует!");
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

            while (true)
            {
                var page = ChoosePage(phoneBook);
                ShowPage(page);


                Console.ReadLine();
                Console.Clear();
            }
        }
    }
 
}
