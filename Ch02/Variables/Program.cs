object height = 1.88;
object name = "Amir";
System.Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} chracters.");

dynamic something;
something = new[] {3,5,7};
//something = 12;
//something = "Ahmed";
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");