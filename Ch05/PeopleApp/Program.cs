using Packt.Shared;

ConfigureConsole();
Person bob = new();
WriteLine(bob);

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22, hour: 14, minute: 28, second: 0, offset: TimeSpan.FromHours(-5));
WriteLine(format: "{0} was born on {1:D} ({1:d}).", bob.Name, bob.Born);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatusOfZeusAtOlympia;
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
