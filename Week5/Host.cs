namespace Week5
{
    public class Host
    { 
        private string Expertise { get; set; }
        public Host(int id, string name, string expertise)
        {
            Expertise = expertise;
        }
        public string ToString()
        {
        }
    }
}
