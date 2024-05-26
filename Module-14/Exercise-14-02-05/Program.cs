namespace Exercise_14_02_05
{
    internal class Program
    {
        static void ShowPage(List<Contact> list)
        {
            foreach (Contact contact in list)
            {
                Console.WriteLine(contact.Name+" "+contact.Phone);
            }
        }

        static List<Contact> ChoosePage(string input, List<Contact> list)
        {
            List < Contact > page= null;
            if (input == "1") page = list.Take(2).ToList();
            else if (input=="2")page=list.Skip(2).Take(2).ToList();
            else if (input=="3")page=list.Skip(4).ToList();
            else page=null;

            return page;
        }
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }               
            };
       
            while (true)
            {
                Console.Write("Введите номер страницы: ");
                var inputPage=Console.ReadLine();

                var page = ChoosePage(inputPage, contacts);

                if (page != null)
                {
                    ShowPage(page);
                    
                }
                else
                {
                    Console.WriteLine("Страницы не существует!");
                }



                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
