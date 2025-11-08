namespace Week6
{
    public class Eatable : FoodItem
    {
        public Eatable(string name, decimal price)
            :base(name, price)
        { }

        public override string ToString()
        {
            return $"Food: {Name} - {Price}$";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
