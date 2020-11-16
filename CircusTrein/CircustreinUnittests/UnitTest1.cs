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
            Program.AnimalContainer.CreateAnimal("Plant", "Medium");
            Program.AnimalContainer.CreateAnimal("Meat", "Medium");
            Program.AnimalContainer.CreateAnimal("Meat", "Small");

            Program.WagonController.CheckNextAnimal();

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

            for (int i = 0; i < wagonContainerTest.wagonList.Count; i++)
            {
                Assert.AreEqual(wagonContainerTest.wagonList[i].WagonAnimalList[0].ToString(), Program.WagonContainer.wagonList[i].WagonAnimalList[0].ToString());
            }
        }
    }
}
