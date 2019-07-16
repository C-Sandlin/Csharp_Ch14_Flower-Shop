using System;

namespace Flowershop
{
    public class Tulip : Flower, IDescribable, IColor, IStemLength
    {

        // Clusianae (4 species)
        // Orithyia (4 species)
        // Tulipa (52 species)
        // Eriostemones (16 species)
        public string Color { get; set; }
        public bool HasThorns { get; set; }
        public string Species { get; set; }
        public double StemLength { get; set; }

        public int PetalCount { get; set; }


        public string Describe()
        {
            return $"A lovely {Color} Tulip";
        }
    }
}
