using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class AnimalContainer
    {
        public List<Animal> animalList = new List<Animal>();

        public void CreateAnimal(string diet, string size)
        {
            Animal animal = new Animal(diet, size);
            animalList.Add(animal);
        }
    }
}
