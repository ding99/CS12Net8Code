namespace Packt.Shared;

public partial class Person {
    public string? Name;
    public DateTimeOffset Born;
    //move to ParsonAutoGen.cs as a property
    //public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = [];
    public readonly string HomePlanet = "Earth";


    public void Deconstruct(out string? name, out DateTimeOffset dob){
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav){
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }
}
