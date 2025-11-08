using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract void DisplayInfo();
    }
}
