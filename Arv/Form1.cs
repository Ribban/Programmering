using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arv
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();

            animals.Add(new Cat("Khajit"));
            animals.Add(new Dog("Pogger"));
            animals.Add(new Bird("Egg"));

            foreach (Animal a in animals)
            {
                cbNames.Items.Add(a.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbNames.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Animal animal = animals[selectedIndex];
                lbSpecies.Text = animal.Species.ToString();
                pictureBox1.Image = imageList1.Images[(int)animal.Species];
                lbCanFly.Text = (animal.CanFly ? "Kan flyga" : "Kan inte flyga");
            } else
            {
                lbSpecies.Text = "";
                lbCanFly.Text = "";
                pictureBox1.Image = null;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
