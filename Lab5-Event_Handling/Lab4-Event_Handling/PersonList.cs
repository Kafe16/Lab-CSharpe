
using Lab5_Event_Handling;
using System.Reflection;

namespace Lab5_Event_Handling
{
    public class PersonList
    {
        private List<Person> pers = new(); // Field list of person
        public PersonList()
        {
            Person.Created += p => pers.Add(p); // Register delegate instance
            //Created is Static event so we use it with Person
        }

        // Property
        public List<string> Genders => pers.Select(p => p.Gender).Distinct().ToList(); // Distinct() : មិនយកតម្លៃស្ទួន

        public void GenderGroupView()
        {
            foreach (string gender in Genders)
            {
                Console.WriteLine($"[{gender}]");
                pers.Where(p => p.Gender == gender).ToList().ForEach(p => Console.WriteLine(p.Info));
                Console.WriteLine();
            }
        }

    }

}