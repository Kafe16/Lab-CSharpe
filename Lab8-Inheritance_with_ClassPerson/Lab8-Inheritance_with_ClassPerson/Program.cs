using PersonLib;
using System.Security.Cryptography.X509Certificates;

namespace Lab8_Inheritance_with_ClassPerson
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
            LoadData("Data.txt");
            Application.Run(new Person());
        }
        public static PersonListX PersonList = new PersonListX();

        private static void LoadData(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] arr = line.Split('/');
                if (arr.Length < 2) continue;
                string name = arr[0];
                string gender = arr[1];

                if (byte.TryParse(arr[2], out byte age) == false) continue;

                PersonLib.Person person = new PersonLib.Person(name, gender, age);
                PersonList.Add(person);
            }
        }
    }
}