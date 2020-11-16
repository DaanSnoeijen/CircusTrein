using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public string diet { get; private set; }
        public string size { get; private set; }
        public int points { get; private set; }
        public bool inWagon = false;
        public bool canEnter = true;

        public Animal(string Diet, string Size)
        {
            diet = Diet;
            size = Size;

            if (size == "Small")
            {
                points = 1;
            }
            else if (size == "Medium")
            {
                points = 3;
            }
            else if (size == "Large")
            {
                points = 5;
            }
        }

        public override string ToString()
        {
            string animal = "Animal diet: " + diet + ". Size: " + size + ".";
            return animal;
        }
    }
}
