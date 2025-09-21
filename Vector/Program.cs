namespace Vector;

public class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector() { X = 3, Y = 7 };

        Vector v2 = v1;
        
        System.Console.WriteLine(v1.AngleBetween(v2));
    }
}

