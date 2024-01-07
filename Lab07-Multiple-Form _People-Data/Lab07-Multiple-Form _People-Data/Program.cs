namespace Lab07_Multiple_Form__People_Data
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoadPersons("Person.txt");
            Application.Run(new MainForm());
        }


        private static void LoadPersons(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] arr = line.Split('|');
                if (arr.Length < 2) continue;
                string name = arr[0];
                string gender = arr[1];

                if (byte.TryParse(arr[2], out byte age) == false) continue;

                Person per = new(name, gender, age);
                person.Add(per);
            }
        }
        public static List<Person> person = new();
    }
}