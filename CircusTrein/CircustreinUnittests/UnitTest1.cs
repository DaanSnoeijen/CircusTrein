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
            //Algorythm
            AnimalContainer animalContainer = new AnimalContainer();
            animalContainer.CreateAnimal("Plant", "Medium");
            animalContainer.CreateAnimal("Meat", "Medium");
            animalContainer.CreateAnimal("Meat", "Small");

            WagonContainer wagonContainer = new WagonContainer();

            WagonController wagonController = new WagonController();
            wagonController.CheckNextAnimal();

            //Expected outcome
            AnimalContainer animalContainerTest = new AnimalContainer();
            animalContainerTest.CreateAnimal("Plant", "Medium");
            animalContainerTest.CreateAnimal("Meat", "Medium");
            animalContainerTest.CreateAnimal("Meat", "Small");

            WagonContainer wagonContainerTest = new WagonContainer();
            wagonContainerTest.AddWagon();
            wagonContainerTest.AddWagon();
            wagonContainerTest.wagonList[0].WagonAnimalList.Add(animalContainerTest.animalList[0]);
            wagonContainerTest.wagonList[0].WagonAnimalList.Add(animalContainerTest.animalList[2]);
            wagonContainerTest.wagonList[1].WagonAnimalList.Add(animalContainerTest.animalList[1]);

            Assert.AreEqual(wagonContainerTest.wagonList, wagonContainer.wagonList);
        }
    }
}
