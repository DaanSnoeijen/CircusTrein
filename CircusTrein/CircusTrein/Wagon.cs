using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public int points;
        public int maxPoints { get; private set; } = 10;

        public List<Animal> WagonAnimalList = new List<Animal>();

        public override string ToString()
        {
            return Convert.ToString(Program.WagonContainer.wagonList.IndexOf(this) + 1 + " Aantal dieren in wagon: " + WagonAnimalList.Count);
        }
    }
}
