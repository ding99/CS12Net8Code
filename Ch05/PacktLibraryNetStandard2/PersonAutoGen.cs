namespace Packt.Shared;

public partial class Person {

    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}.", Name, HomePlanet);
        }
    }

    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - Born.Year;

    public string? FavoriteIceCream { get; set; }

    private WondersOfTheAncientWorld _favoriteAncientWonder;
    public WondersOfTheAncientWorld FavoriteAncientWonder{
        get { return _favoriteAncientWonder; }
        set {
            string wonderName = value.ToString();
            if(wonderName.Contains(',')){
                throw new ArgumentException(
                    message: "Favorite ancient wonder can only have a single enum value.",
                    paramName: nameof(FavoriteAncientWonder));
            }
            if(!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value)){
                throw new ArgumentException(
                $"{value} is not a member of the WondersOfTheAncientWorld enum.",
                paramName: nameof(FavoriteAncientWonder));
            }
            _favoriteAncientWonder = value;
        }
    }

    private string? _favoritePrimaryColor;

    public string? FavoritePrimaryColor{
        get { return _favoritePrimaryColor; }
        set {
            switch (value?.ToLower()) {
                case "red":
                case "green":
                case "blue":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException($"{value} is not a primary color." + "Choose from: red, green, blue");
            }
        }
    }

}