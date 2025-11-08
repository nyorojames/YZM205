public class Warrior : Character
{
    private int Armor { get; set; }
    public Weapon Weapon { get; set; }

    public Warrior(string name, int health, int damage, int armor, int level, Weapon weapon)
        : base(name, health, damage, level)
    {
        Armor = armor;
        Weapon = weapon;
    }

    public void PowerAttack(Character target)
    {
        int totalDamage = Weapon.Use() + Damage;
        target.TakeDamage(totalDamage);
        Console.WriteLine($"{base.Name} performs a Power Attack on {target.Name} and deals {base.Damage} damage!");
        Weapon.DisplayInfo();
    }

    public void Defend(int IncomingDamage)
    {
        Damage += IncomingDamage * Armor;
        Console.WriteLine($"{Name} defends with armor ({Armor}% reduction)”");
        TakeDamage(Damage);
    }
}

public class Mage : Character
{
    private int Mana { get; set; }
    public Spell Spell { get; set; }

    public Mage(string name, int health, int damage, int mana, int level, Spell spell)
        : base(name, health, damage, level)
    {
        Mana = mana;
        Spell = spell;
    }

    public void CastSpell(Character target)
    {
        if (Mana >= 10)
        {   
            int totalDamage = Spell.GetPower() + Damage;
            target.TakeDamage(totalDamage);
            Mana -= Spell.GetManaCost();
            Console.WriteLine($"{Name} casts a spell on {target.Name} for {Damage} damage!");
            Spell.DisplayInfo();
        }
        Console.WriteLine($"{Name} is out of mana");
                
    }
    public void RechargeMana(int amount)
    {
        if (Mana < 100) 
            Mana += amount;
        Console.WriteLine($"{Name} recharged mana. Current mana: {Mana}");
    }
}
