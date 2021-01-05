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
            IAnimalContainer animalContainer = new AnimalContainer();
            IWagonContainer wagonContainer = new WagonContainer();

            WagonController wagonController = new WagonController(animalContainer, wagonContainer);

            animalContainer.CreateAnimal(diet.Plants, size.Small);
            animalContainer.CreateAnimal(diet.Meat, size.Medium);
            animalContainer.CreateAnimal(diet.Plants, size.Large);
            animalContainer.CreateAnimal(diet.Meat, size.Small);
            animalContainer.CreateAnimal(diet.Meat, size.Large);
            animalContainer.CreateAnimal(diet.Plants, size.Medium);
            animalContainer.CreateAnimal(diet.Plants, size.Small);
            animalContainer.CreateAnimal(diet.Meat, size.Medium);
            animalContainer.CreateAnimal(diet.Plants, size.Large);
            animalContainer.CreateAnimal(diet.Meat, size.Small);
            animalContainer.CreateAnimal(diet.Plants, size.Small);
            animalContainer.CreateAnimal(diet.Plants, size.Medium);
            animalContainer.CreateAnimal(diet.Meat, size.Large);
            animalContainer.CreateAnimal(diet.Meat, size.Medium);
            animalContainer.CreateAnimal(diet.Plants, size.Large);
            animalContainer.CreateAnimal(diet.Meat, size.Small);
            animalContainer.CreateAnimal(diet.Plants, size.Medium);
            animalContainer.CreateAnimal(diet.Meat, size.Large);

            //act
            wagonController.CheckNextAnimal();

            //assert
            for (int i = 0; i < wagonContainer.WagonList().Count; i++)
            {
                int totalPoints = 0;

                foreach (Animal animal in wagonContainer.WagonList()[i].WagonAnimalList)
                {
                    totalPoints += animal.points;

                    foreach (Animal otherAnimal in wagonContainer.WagonList()[i].WagonAnimalList)
                    {
                        Assert.IsFalse(wagonContainer.WagonList()[i].WagonAnimalList.IndexOf(animal) != wagonContainer.WagonList()[i].WagonAnimalList.IndexOf(otherAnimal) && animal.Diet == diet.Meat && animal.points >= otherAnimal.points);
                    }
                }

                Assert.IsFalse(totalPoints > 10);
            }
        }

        [TestMethod]
        public void TestAnimalAdd()
        {
            //arrange
            IAnimalContainer animalContainer = new AnimalContainer();

            //act
            animalContainer.CreateAnimal(diet.Meat, size.Large);

            //assert
            Assert.IsTrue(animalContainer.AnimalList().Count == 1);
        }

        [TestMethod]
        public void TestWagonAdd()
        {
            //arrange
            IWagonContainer wagonContainer = new WagonContainer();

            //act
            wagonContainer.AddWagon();

            //assert
            Assert.IsTrue(wagonContainer.WagonList().Count == 1);
        }
    }
}
