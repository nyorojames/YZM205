using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

public class Character
{
    public string Name { get; set; }
    protected int Health { get; set; }
    protected int Level { get; set; }
    protected int Damage { get; set; }

    public Character(string name, int health, int damage, int level)
    {
        Name = name;
        Health = health;
        Level = level;
        Damage = damage;
    }

    public void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} and deals {Damage} damage");
        target.TakeDamage(Damage);

    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name}'s remaining health: {Health}");
    }

    public void DisplayStats() => Console.WriteLine($"Name: {Name}, Health: {Health}, Damage: {Damage}");

    public bool isAlive()
    {
        if (Health > 0)
            return true;
        return false;
    }
}


