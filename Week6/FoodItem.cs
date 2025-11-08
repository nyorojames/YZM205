using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public abstract class FoodItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public FoodItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price}$";
        }

        public abstract void DisplayInfo();
    }
}
