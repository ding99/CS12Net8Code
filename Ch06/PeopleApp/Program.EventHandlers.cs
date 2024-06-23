using Packt.Shared;

partial class Program{
    private static void Harry_Shout(object? sender, EventArgs e){
        if(sender is null){
            return;
        }
        if(sender is not Person p){
            return;
        }
        WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
    }
}