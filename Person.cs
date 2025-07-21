using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP2
{
    internal struct Person
    {
        public int age { get; set; }
        public string name { get; set; }


        public      Person(int _age,string _name)
        {
            age = _age;
            name = _name;
            
        }


        public override string ToString()
        {
            return $"name is {name} and the age is {age}";
        }
    }
}
