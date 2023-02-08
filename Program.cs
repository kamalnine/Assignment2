using Assignment2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Registration Number: ");
        String a = Console.ReadLine();
        Console.WriteLine("Enter Driver Name: ");
        String b = Console.ReadLine();
        Console.WriteLine("Enter Vehicle type: ");
        String c = Console.ReadLine();
        Console.Write("Enter costPerKm: ");
        float d = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Vehicle v = new Vehicle();

        Vehicle v1 = new Vehicle(a,b,c,d);



        v1.Display();
    }
}