Warrior warrior = new Warrior("Thorin", 150, 20, 18, 1, new Weapon("Sword", 50, 30));

Mage mage = new Mage("Gandalf", 100, 15, 100, 1, new Spell("light rain", 35, 5,"light"));

warrior.PowerAttack(mage);
warrior.Defend(15);
warrior.DisplayStats();
Console.WriteLine();

mage.CastSpell(warrior);
mage.RechargeMana(20);
mage.DisplayStats();

