using System.Numerics;

public class Weapon
{
    public string Name { get; set; }
    private int Power { get; set; }
    private int _durability; 
    public int Durability
    {
        get { return _durability; }
        set
        {
            if (value < 0)
                _durability = 0;
            else if (value > 100)
                _durability = 100;
            else
                _durability = value;
        }
    }
    public Weapon(string name, int power, int durability)
    {
        Name = name;
        Power = power;
        Durability = durability;
    }
    public int Use()
    {
        return Power;
    }
    public void Repair(int amount)
    {
        Durability += amount;
    }
    public void DisplayInfo() => Console.WriteLine($"Weapon: {Name}, Power: {Power}, Durability: {Durability}");
}


public class Spell
{ 
    public string Name { get; set; }
    private int Power { get; set; }
    private int ManaCost { get; set; }
    private string Element { get; set; }
    public Spell(string name, int power, int manaCost, string element)
    {
        Name = name;
        Power = power;
        ManaCost = manaCost;
        Element = element;
    }
    public int GetPower() => Power;
    public int GetManaCost() => ManaCost;
    public int Cast()
    {
        Console.WriteLine($"Casting {Name} ({Element}) - Power: {Power}, ManaCost: {ManaCost}");
        return Power;
    }
    public void DisplayInfo() => Console.WriteLine($"Spell: {Name}, Power: {Power}, ManaCost: {ManaCost}, Element: {Element}");

}