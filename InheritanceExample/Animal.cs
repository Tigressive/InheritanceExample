namespace InheritanceExample;

public class Animal
{
    public string name { set; get; }

    public void Eat()
    {
        Console.WriteLine($"{name} is eating!");
    }
}