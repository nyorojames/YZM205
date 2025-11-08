using System;
namespace Week6
{
    public class DeliveryDriver : Person, IComparable<DeliveryDriver>
    {
        public int DeliveryCount { get; private set; }
        public DeliveryDriver(int id, string name)
            :base(id, name)
        {
            DeliveryCount = 0;
        }
        public void AssignDelivery()
        {
            DeliveryCount++;
        }
        public int CompareTo(DeliveryDriver? other)
        {
            if (other is null) return 1;
            return DeliveryCount.CompareTo(other.DeliveryCount);
        }

        public override string ToString()
        {
            return $"Driver: {Name} - Delivered: {DeliveryCount}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
