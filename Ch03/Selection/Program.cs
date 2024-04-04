
#region is
Console.ForegroundColor = ConsoleColor.Yellow;
object o = 3;
//object o = "3";
int j = 4;
if (o is int i) {
    Console.WriteLine($"{i} x {j} = {i*j}");
} else {
    Console.WriteLine("o is not an int so it cannot multiply!");
}
#endregion

#region swt
Console.ForegroundColor = ConsoleColor.Cyan;
int number = Random.Shared.Next(1, 7);
Console.WriteLine($"My random number is {number}");
switch(number) {
case 1:
    Console.WriteLine("One");
    break;
case 2:
    Console.WriteLine("Two");
    goto case 1;
case 3:
case 4:
    Console.WriteLine("Three or four");
    goto case 1;
case 5:
    goto A_label;
default:
    Console.WriteLine("Default");
    break;
}
Console.WriteLine("After end of switch");
A_label:
Console.WriteLine("After A_label");
#endregion

#region pattern
Console.ForegroundColor = ConsoleColor.Yellow;
var animals = new Animal?[]{
    new Cat {Name = "Karen", Born=new(2022,8,23), Legs=4, IsDomestic=true},
    null,
    new Cat {Name="Mufasa", Born=new(1994,6,12)},
    new Spider { Name="Sid Vicious", Born=DateTime.Today, isPoisnous=true},
    new Spider { Name="Captain Furry", Born=DateTime.Today}
};
foreach(Animal? animal in animals){
    string message;
    switch (animal) {
    case Cat fourLeggedCat when fourLeggedCat.Legs==4:
        message = $"the cat names {fourLeggedCat.Name} has four legs.";
        break;
    case Cat wildCat when wildCat.IsDomestic==false:
        message=$"The non-domestic cat is named {wildCat.Name}";
        break;
    case Cat cat:
        message=$"The cat is named {cat.Name}";
        break;
    default:
        message=$"{animal.Name} is a {animal.GetType().Name}.";
        break;
    case Spider spider when spider.isPoisnous:
        message=$"The {spider.Name} spider is poisonous. Run!";
        break;
    case null:
        message="The animal is null.";
        break;
    }
    Console.WriteLine($"switch statement:{message}");
    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4 => $"the cat names {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.IsDomestic == false => $"The non-domestic cat is named {wildCat.Name}",
        Cat cat => $"The cat is named {cat.Name}",
        Spider spider when spider.isPoisnous => $"The {spider.Name} spider is poisonous. Run!",
        null => "The animal is null.",
        _ => $"{animal.Name} is a {animal.GetType().Name}.",
    };
    Console.WriteLine($"switch statement:{message}");
}
#endregion

Console.ResetColor();