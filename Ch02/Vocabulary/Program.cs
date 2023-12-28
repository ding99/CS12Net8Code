using System.Reflection;

namespace Vocabulary;

class Program
{
    static void Main(string[] args)
    {
        WriteLine($"Computer named {Env.MachineName} says \"Yes\".");

        Assembly? myApp = Assembly.GetEntryAssembly();
        if (myApp is null)
            return;
        foreach(var name in myApp.GetReferencedAssemblies()){
            Assembly a = Assembly.Load(name);
            int methodCount = 0;
            foreach(var t in a.DefinedTypes)
                methodCount += t.GetMembers().Length;

            WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
                arg0:a.DefinedTypes.Count(),
                arg1:methodCount,
                arg2:name.Name
            );
        }

        System.Data.DataSet ds = new();
        HttpClient client = new();

        double heightInMeters = 1.88;
        System.Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}.");

        string hori = new('-', count:74);
        System.Console.WriteLine($"hori [{hori}]");

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string emj = char.ConvertFromUtf32(0x1f600);
        System.Console.WriteLine(emj);
    }
}
