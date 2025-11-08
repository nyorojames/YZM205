namespace Week6
{
    public class Customer : Person
    { 
        public string Email { get; set; }
        public Customer(int id, string name, string email)
            :base(id, name)
        {
            Email = email;
        }

        public override string ToString()
        {
            return $"Customer: {Name}, Email: {Email}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
