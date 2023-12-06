
/*
 * Create console application with following
 1- Creating a delegate
    public delegate void CreatedHandler (Person p);

 2- Creating a class Person:
    public class Person
    {  
        public string Name{ get; set; } = ""
        public string Gender { get; set; } = "" 
        public byte Age { get; set; } = 0;
        public static event CreatedHandler? Created; // not belong to event, it belongs to class Person itself
        // Create event

        // Use to create obj Person
        public static void Create ( string name, string gender, byte age)
        {
            Person p = new() { Name = name, Gender = gender, Age = age;};
            Create?.Invoke(p); // Raise Event
        }
        private Person(){} // Not allow to create obj Person outside

        //Instance Property
        public string Info => $"name:{Name}, gender:{Gender},age:{Age}"; // read only property

    }

 3- Creating a class PersonList:
    => PersonList is a client of Class Person
    public class PersonList
    {
        private List<Person> pers = new(); // Field list of person
        public PersonList()
        { 
            Person.Created += p=> pers.Add(p); // Register delegate instance
            //Created is Static event so we use it with Person
        }
        
        // Property
        public List<string> Genders => pers.Select(p=>p.Gender).Distinct().ToList(); // Distinct() : មិនយកតម្លៃស្ទួន

        public void GenderGroupView()
        {
            foreach(string gender in Gender)
            {
                Console.WriteLine($"[{gender}]");
                pers.Where(p=>p.Gender == gender).ToList().Foreach(p=>Console.WriteLine(p.Info));
                Console.WriteLine();
            }
        }

    }

 4- Coding in PRogram.Main()

    PersonList people = new();
    Person.Create("Heng Long" , "Male" , 25);
    .
    .
    .
    Person.Create("Park Kim" , "Male" , 35);
    
    People.GenderGroupView();


*/
namespace Lab5_Event_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----- Lab5 Event Handling ----->");
        
            PersonList person = new PersonList();

            Person.Create("Heng Long", "Male", 45);
            Person.Create("Heng Soy", "Female", 45);
            Person.Create("Long Short", "Male", 19);
            Person.Create("Hong Long", "Male", 65);
            Person.Create("Heng Lucky", "Female", 63);
            Person.Create("Heng LongLong", "Female", 34);
            Person.Create("Heng London", "Male", 23);

            person.GenderGroupView();
        }
    }
   

}