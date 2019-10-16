using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        static string filename = ""; // Skapar en tom sträng
        public Form1()
        {
            InitializeComponent();
        }
        private void open_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog(); //Öppnar menyn för att välja fil
            if (dialogResult == DialogResult.OK) // Om man väljer en fil
            {
                filename = openFileDialog1.FileName; // Sparar filen på en sträng för att spara som vanligt
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName); // Fyller richboxen med innehållet från filen
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog1.ShowDialog(); //Öppnar menyn för att välja fil
            if (dialogResult == DialogResult.OK) // Om man väljer en fil
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text); // Skriver allting i richboxen till en fil
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Avslutar programmet
        }

        private void save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(filename, richTextBox1.Text); // Sparar allting från richboxen till den öppnade filen
        }
    }
}
