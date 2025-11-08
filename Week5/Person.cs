namespace Week5
{
    public class Person
    {
        private int Id { get; set; }
        private string Name { get; set; }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public string ToString()
        {
        }
    }
}
