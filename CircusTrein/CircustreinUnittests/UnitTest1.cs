using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;

namespace CircustreinUnittests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Program.AnimalContainer.CreateAnimal("Plants", "Small");
            Program.AnimalContainer.CreateAnimal("Meat", "Medium");
            Program.AnimalContainer.CreateAnimal("Plants", "Large");
            Program.AnimalContainer.CreateAnimal("Meat", "Small");
            Program.AnimalContainer.CreateAnimal("Meat", "Large");
            Program.AnimalContainer.CreateAnimal("Plants", "Medium");
            Program.AnimalContainer.CreateAnimal("Plants", "Small");
            Program.AnimalContainer.CreateAnimal("Meat", "Medium");
            Program.AnimalContainer.CreateAnimal("Plants", "Large");
            Program.AnimalContainer.CreateAnimal("Meat", "Small");
            Program.AnimalContainer.CreateAnimal("Plants", "Small");
            Program.AnimalContainer.CreateAnimal("Plants", "Medium");
            Program.AnimalContainer.CreateAnimal("Meat", "Large");
            Program.AnimalContainer.CreateAnimal("Meat", "Medium");
            Program.AnimalContainer.CreateAnimal("Plants", "Large");
            Program.AnimalContainer.CreateAnimal("Meat", "Small");
            Program.AnimalContainer.CreateAnimal("Plants", "Medium");
            Program.AnimalContainer.CreateAnimal("Meat", "Large");

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
                        Assert.IsFalse(Program.WagonContainer.wagonList[i].WagonAnimalList.IndexOf(animal) != Program.WagonContainer.wagonList[i].WagonAnimalList.IndexOf(otherAnimal) && animal.diet == "Meat" && animal.points >= otherAnimal.points);
                    }
                }

                Assert.IsFalse(totalPoints > 10);
            }
        }
    }
}
