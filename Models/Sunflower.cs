using System;

namespace Flowershop
{
    public class Sunflower : Flower, IDescribable, IStemLength
    {
        public bool HasThorns { get; set; }
        public bool ReadyToHarvest { get; set; }
        public double StemLength { get; set; }

        public int PetalCount { get; set; }


        public string Describe()
        {
            return $"A lovely {StemLength} foot tall Sunflower";
        }
    }
}
