using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class WagonController
    {
        //check if animal is not in wagon
        public void CheckNextAnimal()
        {
            foreach (Animal animal in Program.AnimalContainer.animalList)
            {
                if (!animal.inWagon)
                {
                    CheckWagon(animal);
                }
            }
        }

        //check if there's a wagon
        public void CheckWagon(Animal animal)
        {
            if (Program.WagonContainer.wagonList.Count == 0)
            {
                //make wagon
                Program.WagonContainer.AddWagon();

                //put animal in wagon
                Program.WagonContainer.wagonList[Program.WagonContainer.wagonList.Count - 1].WagonAnimalList.Add(animal);
                Program.WagonContainer.wagonList[Program.WagonContainer.wagonList.Count - 1].points += animal.points;
                animal.inWagon = true;

                //start over
                CheckNextAnimal();
            }
            else
            {
                CheckSpacePreviousWagons(animal, 0);
            }
        }

        //check if previous wagons have enough space for new animal
        public void CheckSpacePreviousWagons(Animal animal, int index)
        {
            //check every wagon
            for (int i = index; i < Program.WagonContainer.wagonList.Count; i++)
            {
                //check space inside wagon
                if (Program.WagonContainer.wagonList[i].points + animal.points <= Program.WagonContainer.wagonList[i].maxPoints)
                {
                    CheckFood(animal, Program.WagonContainer.wagonList[i]);
                }
            }

            if (!animal.inWagon)
            {
                //make wagon
                Program.WagonContainer.AddWagon();

                //put animal in wagon
                Program.WagonContainer.wagonList[Program.WagonContainer.wagonList.Count - 1].WagonAnimalList.Add(animal);
                Program.WagonContainer.wagonList[Program.WagonContainer.wagonList.Count - 1].points += animal.points;
                animal.inWagon = true;

                //start over
                CheckNextAnimal();
            }
        }

        //check if animals will eat eachother
        public void CheckFood(Animal animal, Wagon wagon)
        {
            for (int i = 0; i < wagon.WagonAnimalList.Count; i++)
            {
                //check if animals will eat eachother
                if (animal.diet == "Meat" && animal.points >= wagon.WagonAnimalList[i].points || wagon.WagonAnimalList[i].diet == "Meat" && wagon.WagonAnimalList[i].points >= animal.points)
                {
                    animal.canEnter = false;
                }
            }

            if (animal.canEnter)
            {
                //put animal in wagon
                wagon.WagonAnimalList.Add(animal);
                wagon.points += animal.points;
                animal.inWagon = true;

                //start over
                CheckNextAnimal();
            }
            else
            {
                CheckSpacePreviousWagons(animal, Program.WagonContainer.wagonList.IndexOf(wagon) + 1);
            }
        }
    }
}