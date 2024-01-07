namespace Lab07_Multiple_Form__People_Data
{
    public delegate void CreateHandler(Person p);
    public class Person
    {

        // Auto Properties
        public int No { get; init; }
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public byte Age { get; set; } = 0;
        //public static event CreateHandler? Created;

        // Constuctor
        public Person(string name, string gender, byte age)
        {
            No = ++count; // Auto create 
            Name = name;
            Gender = gender;
            Age = age;
        }
        private static int count = 0;   

    }
}