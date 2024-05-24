namespace Exercise_14_00_004
{
    //Задача: выбрать имена на букву А и отсортировать в алфавитном порядке.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            var peopleOnA=new List<string>();

            foreach(string person in people)
            {
                var personToChar=person.ToCharArray();
                if (personToChar[0] == 'А')
                {
                    peopleOnA.Add(person);
                }
            }
            peopleOnA.Sort();

            foreach(string person in peopleOnA)
            {
                Console.WriteLine(person);
            }
        }
    }
}
