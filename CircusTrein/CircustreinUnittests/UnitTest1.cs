using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;

namespace CircustreinUnittests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAlgorythm()
        {
            //arrange
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Small);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Medium);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Large);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Small);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Large);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Medium);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Small);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Medium);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Large);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Small);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Small);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Medium);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Large);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Medium);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Large);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Small);
            Program.AnimalContainer.CreateAnimal(diet.Plants, size.Medium);
            Program.AnimalContainer.CreateAnimal(diet.Meat, size.Large);

            //act
            Program.WagonController.CheckNextAnimal();

            //assert
            for (int i = 0; i < Program.WagonContainer.wagonList.Count; i++)
            {
                int totalPoints = 0;

                foreach (Animal animal in Program.WagonContainer.wagonList[i].WagonAnimalList)
                {
                    totalPoints += animal.points;

                    foreach (Animal otherAnimal in Program.WagonContainer.wagonList[i].WagonAnimalList)
                    {
                        Assert.IsFalse(Program.WagonContainer.wagonList[i].WagonAnimalList.IndexOf(animal) != Program.WagonContainer.wagonList[i].WagonAnimalList.IndexOf(otherAnimal) && animal.Diet == diet.Meat && animal.points >= otherAnimal.points);
                    }
                }

                Assert.IsFalse(totalPoints > 10);
            }
        }

        [TestMethod]
        public void TestAnimalAdd()
        {
            //arrange
            AnimalContainer animalContainer = new AnimalContainer();

            //act
            animalContainer.CreateAnimal(diet.Meat, size.Large);

            //assert
            Assert.IsTrue(animalContainer.animalList.Count == 1);
        }

        [TestMethod]
        public void TestWagonAdd()
        {
            //arrange
            WagonContainer wagonContainer = new WagonContainer();

            //act
            wagonContainer.AddWagon();

            //assert
            Assert.IsTrue(wagonContainer.wagonList.Count == 1);
        }
    }
}
