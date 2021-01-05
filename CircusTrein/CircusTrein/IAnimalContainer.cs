using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public interface IAnimalContainer
    {
        void CreateAnimal(diet Diet, size Size);

        List<Animal> AnimalList();
    }
}
