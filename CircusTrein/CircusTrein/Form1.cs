using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        IAnimalContainer AnimalContainer;
        IWagonContainer WagonContainer;

        string animalsInWagon;

        public Form1(IAnimalContainer animalContainer, IWagonContainer wagonContainer)
        {
            AnimalContainer = animalContainer;
            WagonContainer = wagonContainer;

            InitializeComponent();
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalContainer.CreateAnimal((diet)DietBox.SelectedItem, (size)SizeBox.SelectedItem);

                AnimalBox.Items.Clear();
                foreach (Animal animal in AnimalContainer.AnimalList())
                {
                    AnimalBox.Items.Add(animal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            WagonBox.Items.Clear();

            Program.WagonController.CheckNextAnimal();

            foreach (Wagon wagon in WagonContainer.WagonList())
            {
                WagonBox.Items.Add(wagon);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (AnimalBox.SelectedItem != null)
            {
                AnimalContainer.AnimalList().RemoveAt(AnimalBox.SelectedIndex);
                AnimalBox.Items.RemoveAt(AnimalBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an animal to remove first");
            }
        }

        private void WagonBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            animalsInWagon = "";

            foreach (Animal animal in WagonContainer.WagonList()[WagonBox.SelectedIndex].WagonAnimalList)
            {
                animalsInWagon += animal.ToString() + System.Environment.NewLine;
            }

            MessageBox.Show(animalsInWagon);
        }
    }
}
