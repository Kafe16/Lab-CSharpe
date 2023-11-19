namespace _05_Person_With_Sort_Function
{
    public class Person {

        // Instance Fields
        protected string _name = "";
        protected string _gender = "";
        protected int _age = 0;
    
        public string getName() { return _name; }
        public string getGender() { return _gender;}
        public int getAge() { return _age;}

        public static string getBar(char s = '-') 
        {
            return new string(s, 30 + 10 + 9 + 2);
        }

        public bool SetData(string data, string separator = "")
        {
            string[] arr = data.Split(separator);
            if (arr.Length < 3) return false;
            if (int.TryParse(arr[2], out _age)== false) return false; 
            _name = arr[0].Trim();
            _gender = arr[1].Trim();
            
            return true;
        }

        public string getInfo() => $"{_name,-30}{_gender, -10}{_age, 9}";
        public static string getHeading() => $"{"Name", -30}{"Gender", -10}{"Age",9}";

        // Static Methods:
        /*
        public static List<Person> GetPerson (string fileName)
        {
            Console.SetIn(File.OpenText(fileName));
            var result = new List<Person>();
            // add Data into List
            while (true)
            {
                var line = Console.ReadLine();
                if(line == null) break;
                //Person person = new Person();
                Person person = new();

                if (person.SetData(line, "/") == false) continue;
                result.Add(person);
            }
                
            return result;
        }
        */
        // Method to output
        
    }
}