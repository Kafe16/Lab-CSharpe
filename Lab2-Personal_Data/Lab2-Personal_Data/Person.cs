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
 
    + setData() , getInfo(),
 */

public class Person
{
    string outputFile = "person.txt";

    protected string name = "";
    protected string gender = "";
    protected int age = 0;

    public string getInfo() => $"{name,-30}{gender,-9}{age,3}"; // String Enterpolation. string តម្រឹមឆ្វេង so indent neg 
    public bool setData(string data, string separate=" ")
    {
        string[] seg = data.Split(separate);
        if (seg.Length < 3) return false;
        if (int.TryParse(seg[2], out int ag)==false) return false;
        name = seg[0].Trim(); // Trim() = ["----- AB -----"] => ["AB"]
        gender = seg[1].Trim();
        age = ag;
        return true;
    }
}
