using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex2.Model
{
    internal class Car
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string VIN { get; set; }
        public int ProductionYear { get; set; }

        public Manufacturer Manufacturer { get; set;}

        public int ManufacturerId { get; set; }

    public override string ToString() =>
        $"{Id} {Name} {VIN} {ProductionYear}";
    }
}
