using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex2.Model
{
    internal class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress{ get; set; }

        public override string ToString()=>
            $"{Id} {Name} {Adress}";
       
    }
}
