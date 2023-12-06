internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input Rectangle (width , Length)");
        int n = 0;
        double total = 0;
        string info = "";
        while (true)
        {
            Console.Write($"[{n + 1}]: ");
            string? line = Console.ReadLine(); // input section
            if (string.IsNullOrEmpty(line)) break; // break => Exit Loop

            // "A B" => "A" "B" 
            string[] data = line.Split(' '); // => Array[] = {"A" , "B"}; data[0], data[1]
            if (data.Length < 2) continue; // Will do it again

            // Convert data(string) => double = float returnType.TryParse
            if(double.TryParse(data[0], out double width)==false) continue; // reinput
            if (double.TryParse(data[1], out double length)==false) continue;// reinput

            n++;
            double area = width * length;
            total += area; //total = total + area;
            string lineInfo = $"{n,8} {width,8:n2} {length,8:n2} {area,8:n2}"; // output 
            if (info != "") info += "\n";
            info += lineInfo;
        }
        Console.WriteLine();
        string totalInfo = $"Total: {total:n2}";

        Console.WriteLine(totalInfo);
    }

    
}