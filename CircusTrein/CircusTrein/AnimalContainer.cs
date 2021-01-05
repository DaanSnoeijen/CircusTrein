using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class AnimalContainer : IAnimalContainer
    {
        public List<Animal> animalList = new List<Animal>();

        public void CreateAnimal(diet Diet, size Size)
        {
            Animal animal = new Animal(Diet, Size);
            animalList.Add(animal);
        }

        public List<Animal> AnimalList()
        {
            return animalList;
        }
    }
}
