using System;
using System.Collections.Generic;

namespace Flowershop
{
    public class Flowershop
    {
        public List<Rose> Roses { get; set; }
        public List<Lilly> Lillies { get; set; }
        public List<Sunflower> Sunflowers { get; set; }
        public List<Tulip> Tulips { get; set; }

        // any flower that goes in mothers day : must have stem length
        public List<IStemLength> MothersDayArrangement { get; set; } = new List<IStemLength>()
        {
            new Rose() { PetalCount = 27, Price = 3.00 },
            new Sunflower() { PetalCount = 50, Price = 5.00 },
            // new Lilly() {} - CANT DO THIS BC DOESNT SHARE STEMLENGTH PROPERTY or INTERFACE
            new Tulip() { PetalCount = 40, Price = 1.50 }
        };

        // any flower that goes in bday: must have color
        public List<IColor> BirthDayArrangement { get; set; } = new List<IColor>()
        {
            new Rose() { Color = "red", Price = 3.00 },
            new Tulip() { Color = "red", Price = 2.50 },
            new Lilly() { Color = "yellow", Price = 1.75 }
            // new Sunflower() {} - CANT DO THIS BC DOESNT SHARE COLOR PROPERTY or INTERFACE
        };

    }
}