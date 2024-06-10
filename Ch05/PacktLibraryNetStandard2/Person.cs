namespace Packt.Shared;

public class Person {
    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = [];

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
