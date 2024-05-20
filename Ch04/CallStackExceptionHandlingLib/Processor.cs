using static System.Console;

namespace CallStackExceptionHandlingLib;

public class Processor
{
    public static void Gamma(){
        System.Console.WriteLine("In Gamma");
        Delta();
    }

    public static void Delta(){
        System.Console.WriteLine("In Delta");
        File.OpenText("bad file path");
    }
}
