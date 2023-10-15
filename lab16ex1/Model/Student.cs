using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex1.Model
{
    class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public  Specializari Specializare { get; set; }

        public override string ToString()=>
        $"{Id} {Nume} {Specializare}";  
            
        
    }
}
