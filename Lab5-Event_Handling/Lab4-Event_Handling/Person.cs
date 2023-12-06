
using Lab5_Event_Handling;
using System.Reflection;
using System.Xml.Linq;


namespace Lab5_Event_Handling
{
    public delegate void CreateHandler(Person p);
    public class Person {

        // Auto Properties

        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public byte Age { get; set; } = 0;
        public static event CreateHandler? Created;

        public static void Create(string name, string gender, byte age)
        {
            Person p = new()
            {
                Name = name,
                Gender = gender,
                Age = age
            };
            Created?.Invoke(p); // Raise Event
        }
        private Person() { } // Not allow to create obj Person outside

        //Instance Property
        public string Info => $"name:{Name}, gender:{Gender},age:{Age}"; // read only property

    }

}