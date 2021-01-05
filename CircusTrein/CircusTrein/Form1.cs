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
        string animalsInWagon;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            try
            {
                diet Diet = (diet)DietBox.SelectedItem;
                size Size = (size)SizeBox.SelectedItem;

                Program.AnimalContainer.CreateAnimal(Diet, Size);

                AnimalBox.Items.Clear();
                foreach (Animal animal in Program.AnimalContainer.animalList)
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

            foreach (Wagon wagon in Program.WagonContainer.wagonList)
            {
                WagonBox.Items.Add(wagon);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (AnimalBox.SelectedItem != null)
            {
                Program.AnimalContainer.animalList.RemoveAt(AnimalBox.SelectedIndex);
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

            foreach (Animal animal in Program.WagonContainer.wagonList[WagonBox.SelectedIndex].WagonAnimalList)
            {
                animalsInWagon += animal.ToString() + System.Environment.NewLine;
            }

            MessageBox.Show(animalsInWagon);
        }
    }
}
