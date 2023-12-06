/*
 
    Given a file people.txt with content:
        - Heng Long/Male/23
        = Keo Nary/Female/26
        - San Metrey/Female/33
        - Chan Rosa/Female/27
        - Sok Vanny/Male/18

    Write console Application to read people data from the given file, then out put  their in formation:

    Name            Gender          Age
    -----------------------------------
    Heng Long       Male            23
    

    ----------------------------------

    * Using a class to represent a person's data
    * 
    * Method for class: setData() - getInfo() - 3 fields 
 
 */

Console.WriteLine("-------- OutPut Data from File --------");
//var peopelData = new List<Person>();
string file = "person.txt";
Console.SetIn(File.OpenText(file));

string result = "";

while (true)
{
    string line = Console.ReadLine();
    if(string.IsNullOrEmpty(line)) break;
    Person p = new Person(); //== Person p = new();
    if (p.setData(line, "/") == false) continue;
    if (result != "") result += "\n";
    result += p.getInfo();
}

string heading = $"{"Name",-30}{"Gender",-9}{"Age",3}";
string bar = new string('-', 41);

Console.WriteLine(heading);
Console.WriteLine(bar);
Console.WriteLine(result);
Console.WriteLine(bar);

