namespace Week6
{
    public class Drinkable : FoodItem
    {
        public Drinkable(string name, decimal price)
            : base(name, price)
        { }

        public override string ToString()
        {
            return $"Drink: {Name} - {Price}$";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
