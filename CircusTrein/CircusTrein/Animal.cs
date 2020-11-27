using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public enum diet
    {
        Meat,
        Plants
    }

    public enum size
    {
        Small,
        Medium,
        Large
    }

    public class Animal
    {
        public diet Diet;
        public size Size;

        public int points { get; private set; }
        public bool inWagon = false;
        public bool canEnter = true;

        public Animal(diet diet, size size)
        {
            Diet = diet;
            Size = size;

            if (Size == size.Small)
            {
                points = 1;
            }
            else if (Size == size.Medium)
            {
                points = 3;
            }
            else if (Size == size.Large)
            {
                points = 5;
            }
        }

        public override string ToString()
        {
            string animal = "Animal diet: " + Convert.ToString(Diet) + ". Size: " + Convert.ToString(Size) + ".";
            return animal;
        }
    }
}
