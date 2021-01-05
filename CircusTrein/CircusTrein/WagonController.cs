using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class WagonController
    {
        IAnimalContainer AnimalContainer;
        IWagonContainer WagonContainer;

        public WagonController(IAnimalContainer animalContainer, IWagonContainer wagonContainer)
        {
            AnimalContainer = animalContainer;
            WagonContainer = wagonContainer;
        }

        //check if animal is not in wagon
        public void CheckNextAnimal()
        {
            foreach (Animal animal in AnimalContainer.AnimalList())
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
            if (WagonContainer.WagonList().Count == 0)
            {
                //make wagon
                WagonContainer.AddWagon();

                //put animal in wagon
                WagonContainer.WagonList()[WagonContainer.WagonList().Count - 1].WagonAnimalList.Add(animal);
                WagonContainer.WagonList()[WagonContainer.WagonList().Count - 1].points += animal.points;
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
            for (int i = index; i < WagonContainer.WagonList().Count; i++)
            {
                //check space inside wagon
                if (WagonContainer.WagonList()[i].points + animal.points <= WagonContainer.WagonList()[i].maxPoints)
                {
                    CheckFood(animal, WagonContainer.WagonList()[i]);
                }
            }

            if (!animal.inWagon)
            {
                //make wagon
                WagonContainer.AddWagon();

                //put animal in wagon
                WagonContainer.WagonList()[WagonContainer.WagonList().Count - 1].WagonAnimalList.Add(animal);
                WagonContainer.WagonList()[WagonContainer.WagonList().Count - 1].points += animal.points;
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
                if (animal.Diet == diet.Meat && animal.points >= wagon.WagonAnimalList[i].points || wagon.WagonAnimalList[i].Diet == diet.Meat && wagon.WagonAnimalList[i].points >= animal.points)
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
                CheckSpacePreviousWagons(animal, WagonContainer.WagonList().IndexOf(wagon) + 1);
            }
        }
    }
}