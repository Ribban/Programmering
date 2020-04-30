using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CarApp
{
    public partial class Form1 : Form
    {
        Database dbObject = new Database();
        public Form1()
        {
            InitializeComponent();
            InitListview();
            txtRegNr.Focus();
        }

        private void InitListview()
        {
            List<Car> listOfCars = dbObject.GetRowsFromCars();
            foreach (var car in listOfCars)
            {
                AddCarToListview(car);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNr.Text) || string.IsNullOrEmpty(txtMake.Text)) 
            {
                MessageBox.Show("Du måste fylla i alla rutor", "Felaktig inmatning");
            } else
            {
                Car car = new Car(txtRegNr.Text, txtMake.Text, txtModel.Text, Convert.ToInt32(txtYear.Text), cbxForSale.Checked);
                int result = dbObject.AddCarRow(car);
                MessageBox.Show("Du har lagt till " + Convert.ToString(result) + " antal bilar");
                AddCarToListview(car);
                ClearTextboxes();
                btnClear.Enabled = true;
            }
        }

        private void AddCarToListview(Car car)
        {
            ListViewItem item = CreateListViewItem(car.GetRegNr(), car.GetMake(), car.GetModel(), Convert.ToString(car.GetYear()), car.GetForSale());
                lsvCars.Items.Add(item);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int res = dbObject.RemoveCarRowByRegNr(lsvCars.SelectedItems[0].Text);
            MessageBox.Show("Du har tagit bort " + Convert.ToString(res) + " antal bilar från databasen. ");
            if (res > 0)
            {
                if (lsvCars.SelectedItems.Count > 0)
                {
                    var item = lsvCars.SelectedItems[0];
                    lsvCars.Items.Remove(item);
                    MessageBox.Show("bilen med registeringsnummer " + item.Text + " är borttagen", "Borttag av bil");
                }
                else
                {
                    MessageBox.Show("Ingen bil var markerad att tas bort", "Borttag av bil");
                }
            }
            btnClear.Enabled = (lsvCars.Items.Count > 0);
        }

        private void lsvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lsvCars.SelectedItems.Count > 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsvCars.Clear();
        }
        private ListViewItem CreateListViewItem(string regNr, string make, string model, string year, bool forSale)
        {
            ListViewItem item = new ListViewItem(regNr);
            item.SubItems.Add(make);
            item.SubItems.Add(model);
            item.SubItems.Add(year);
            item.SubItems.Add(forSale ? "Yes" : "No");
            return item;
        }
        private void ClearTextboxes()
        {
            txtRegNr.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            cbxForSale.Checked = false;
            txtRegNr.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRegNr.Text))
            {
                string regNr = txtRegNr.Text.ToUpper();
                PrintData(regNr);
            } else
            {
                MessageBox.Show("Ange ett registeringsnummer", "Inmatning saknas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintData(string regNr)
        {
            string token = "DtIAxcVeOZhJzLnC6LYN3BjwasJw2FIA5hdvgP00lNKw1cM53ddy1iWpll54";
            string call = String.Format($"https://api.biluppgifter.se/api/v1/vehicle/regno/{regNr}?api_token={token}");
            try
            {
                WebRequest request = HttpWebRequest.Create(call);

                WebResponse response = request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string carJSON = reader.ReadToEnd();

                JObject jsonCar = JObject.Parse(carJSON);

                txtMake.Text = jsonCar["data"]["basic"]["data"]["make"].ToString();
                txtModel.Text = jsonCar["data"]["basic"]["data"]["model"].ToString();
                txtYear.Text = jsonCar["data"]["basic"]["data"]["model_year"].ToString();
            } 
            catch (Exception e)
            {
                MessageBox.Show($"Bil med reigsteringsnummer {regNr} kunde inte hittas\n\nMeddelande: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
