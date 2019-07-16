using System;

namespace Flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            Flowershop myShop = new Flowershop();

            foreach (IColor flower in myShop.BirthDayArrangement)
            {
                // BirthdayArrangement is a list of IColors. So, you can only access the ICOLOR properties. 
                // can only do flower.Color. CANNOT do flower.StemLength, etc.

                Console.WriteLine($"{flower.Color}");
            }

            // if you want to get list of roses, or only roses with certain props, etc., use LINQ methods
        }
    }
}
