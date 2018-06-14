using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CarStoreApp
{
    public partial class Form1 : Form
    {
        private void ShowBase()
        {
            listBox.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\C# PROJECTS\\CarStoreApp\\CarStoreApp\\database.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    listBox.Items.Add(child.InnerText);
                }
                listBox.Items.Add(" ");
            }
        }
        private void SaveBase()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\C# PROJECTS\\CarStoreApp\\CarStoreApp\\database.xml");
            XmlNode car = doc.CreateElement("car");
            XmlNode brand = doc.CreateElement("brand");
            brand.InnerText = Brand.Text;
            car.AppendChild(brand);
            XmlNode year = doc.CreateElement("year");
            year.InnerText = Year.Text;
            car.AppendChild(year);
            XmlNode price = doc.CreateElement("price");
            price.InnerText = Price.Text;
            car.AppendChild(price);
            XmlNode mileage = doc.CreateElement("mileage");
            mileage.InnerText = Mileage.Text;
            car.AppendChild(mileage);
            doc.DocumentElement.AppendChild(car);
            doc.Save("D:\\C# PROJECTS\\CarStoreApp\\CarStoreApp\\database.xml");
        }
        public Form1()
        {
            InitializeComponent();
            ShowBase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowBase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Brand.Text) || String.IsNullOrEmpty(Year.Text) || String.IsNullOrEmpty(Price.Text) || String.IsNullOrEmpty(Mileage.Text))
            {
                MessageBox.Show("Invalid Input");
            }
            else
                SaveBase();
        }

        private void Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar=='.'))
            {
                e.Handled = true;
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void Mileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
