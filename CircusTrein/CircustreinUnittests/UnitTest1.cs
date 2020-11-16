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
            Animal animal1 = new Animal("Plant", "Medium");
            Animal animal2 = new Animal("Meat", "Medium");
            Animal animal3 = new Animal("Meat", "Small");

            Wagon wagon1 = new Wagon();
            wagon1.WagonAnimalList.Add(animal1);
            wagon1.WagonAnimalList.Add(animal3);

            Wagon wagon2 = new Wagon();
            wagon2.WagonAnimalList.Add(animal2);

            WagonContainer wagonContainerTest = new WagonContainer();
            wagonContainerTest.wagonList.Add(wagon1);
            wagonContainerTest.wagonList.Add(wagon2);

            Assert.AreEqual(wagonContainerTest.wagonList, wagonContainer.wagonList);
        }
    }
}
