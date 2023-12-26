namespace MyEnv;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Second Project.");
        System.Console.WriteLine(Environment.CurrentDirectory);
        System.Console.WriteLine(Environment.OSVersion.VersionString);
        System.Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
    }
}
