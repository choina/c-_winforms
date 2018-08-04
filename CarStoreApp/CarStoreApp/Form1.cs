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
        string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\database.xml";
        private void ShowBase()
        {
            listView1.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            foreach (XmlNode node in doc.DocumentElement)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    listView1.Items.Add(child.InnerText);
                }
               // listView1.Items.Add(" ");
            }
        }
        private void Rmv()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            if (listView1.SelectedIndices[0] < doc.DocumentElement.ChildNodes.Count)
            {
                doc.DocumentElement.RemoveChild(doc.DocumentElement.ChildNodes[listView1.FocusedItem.Index]);
                doc.Save(path);
                ShowBase();
            }
        }
        private void SaveBase()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
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
            doc.Save(path);
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
            ShowBase();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Rmv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
