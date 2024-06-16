using System.Security.Cryptography;
using Packt.Chared;
using Packt.Shared;

ConfigureConsole();
Person bob = new();
WriteLine(bob);

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22, hour: 14, minute: 28, second: 0, offset: TimeSpan.FromHours(-5));
WriteLine(format: "{0} was born on {1:D} ({1:d}).", bob.Name, bob.Born);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatusOfZeusAtOlympia;
//bob.FavoriteAncientWonder = (WondersOfTheAncientWorld)128;
//bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatusOfZeusAtOlympia | WondersOfTheAncientWorld.GreatPyramidOfGiza;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}.", bob.Name, bob.FavoriteAncientWonder, (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

/*
var book = new Book {
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"

 };
 */
var book = new Book ("978-1803237800", "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals");

var (name1, dob1) = bob;
WriteLine($"Deconstructed person: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

ForegroundColor = ConsoleColor.Cyan;
Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);
sam.FavoriteIceCream = "Chocoloate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
string color = "Cyan";
try{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
}
catch(Exception e){
    WriteLine("Tried to set {0} to '{1}':{2}", nameof(sam.FavoritePrimaryColor), color, e.Message);
}

ForegroundColor = ConsoleColor.Yellow;
sam.Children.Add(new()
{
    Name = "Charlie",
    Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
});
sam.Children.Add(new() {
    Name = "Ella",
    Born = new(2020,12,24,0,0,0,TimeSpan.Zero)
 });
WriteLine($"Sam's first child is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");

ForegroundColor = ConsoleColor.Green;
Passenger[] passengers = {
    new FirstClassPassender{AirMiles=1_419,Name="Suman"},
    new FirstClassPassender{AirMiles=16_562,Name ="Lucy"},
    new BusinessClassPassender{Name = "Janice"},
    new CoachClassPassender{CarryOnKG=25.7,Name="Dave"},
    new CoachClassPassender{CarryOnKG=0,Name="Amit"}
};
foreach(Passenger pg in passengers){
    decimal flightCost = pg switch
    {
        FirstClassPassender p when p.AirMiles > 35_000 => 1_500M,
        FirstClassPassender p when p.AirMiles > 15_000 => 1_750M,
        FirstClassPassender _ => 2_000M,
        BusinessClassPassender _ => 1_000M,
        CoachClassPassender p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassender _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {pg}");
}


ResetColor();