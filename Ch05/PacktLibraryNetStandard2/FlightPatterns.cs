namespace Packt.Chared;
public class Passenger{
    public string? Name{get; set;}
}
public class BusinessClassPassender:Passenger{
    public override string ToString()
    {
        return $"Business Class: {Name}";
    }
}
public class FirstClassPassender:Passenger{
    public int AirMiles{get; set;}
    public override string ToString()
    {
        return $"First Class with {AirMiles:N0} air miles: {Name}";
    }
}
public class CoachClassPassender:Passenger{
    public double CarryOnKG{get; set;}
    public override string ToString()
    {
        return $"Coach Class with {CarryOnKG:N2} KG carry on: {Name}";
    }
}

