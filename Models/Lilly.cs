using System;

namespace Flowershop
{
    public class Lilly : Flower, IDescribable, IColor
    {
        public string Color { get; set; }
        public bool HasThorns { get; set; }
        public bool ReadyForWater { get; set; }

        public int PetalCount { get; set; }


        public string Describe()
        {
            return $"A lovely {Color} Lilly";
        }
    }
}
