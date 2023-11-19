namespace _05_Person_With_Sort_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<--- Console App Reading Data into list --->");

            Person per = new();
            Console.WriteLine("\n<--- Read all data from File ---->");
            List<Person> person = GetPerson("People.txt");
            ViewPeople(person);
            // Create List to store Ppl greater 25
            Console.WriteLine("\n<--- This section is Output about Sort By Age > 25 --->");
            List<Person> filterpeople = FilterForOverAge(person, 25);
            filterpeople.Sort(ageComparison);
            ViewPeople(filterpeople);

            Console.WriteLine("\n<--- This section is Output about Sort By Name --->");
            person.Sort(nameComparison);
            ViewPeople(person);
        }
        
        public static List<Person> GetPerson(string fileName)
        {
            Console.SetIn(File.OpenText(fileName));
            var result = new List<Person>();
            // add Data into List
            while (true)
            {
                var line = Console.ReadLine();
                if (line == null) break;
                //Person person = new Person();
                Person person = new();

                if (person.SetData(line, "/") == false) continue;
                result.Add(person);
            }

            return result;
        }

        public static void ViewPeople(List<Person> pers)
        {
            // output Heading 
            Console.WriteLine(Person.getHeading());
            Console.WriteLine(Person.getBar('='));

            foreach (var p in pers)
                Console.WriteLine(p.getInfo());

            Console.WriteLine(Person.getBar('='));
        }

        public static List<Person> FilterForOverAge(List<Person> pers, int targetAge)
        {
            var result = new List<Person>();
            foreach (var p in pers)
                if (p.getAge() > targetAge) result.Add(p);

            return result;
        }
        // Descending
        static int ageComparison(Person x, Person y)
        {
            return y.getAge().CompareTo(x.getAge());
        }

        // Ascending
        static int nameComparison(Person x, Person y)
        {
            return x.getName().CompareTo(y.getName());
        }
    }
}