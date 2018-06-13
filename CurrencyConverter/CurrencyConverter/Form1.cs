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
using System.Xml.XPath;
using System.IO;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        List<float> list = new List<float>(); //List with currency exchange rates
        float usd = new float();
        float eur = new float();
        float gbp = new float();
        private void UpdatePr()
        {
            List <string> files = new List<string>();
            WebClient ww = new WebClient();
            ww.DownloadFile("http://www.nbp.pl/Kursy/xml/dir.txt", "dir.txt");

            StreamReader rr = new StreamReader("dir.txt");
            string line ="";
            
            while(line != null)
            {
                line = rr.ReadLine();

                    if(line != null)
                {
                    if(line.StartsWith("a"))
                    {
                        files.Add(line);
                    }
                }

            }
            rr.Close();
            XPathDocument document = new XPathDocument("http://www.nbp.pl/kursy/xml/" + files[files.Count - 1] + ".xml");
            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator iterator;
            iterator = navigator.Select("tabela_kursow");

            iterator = navigator.Select("tabela_kursow/pozycja");
            foreach(XPathNavigator nav in iterator)
            {
                    if(nav.SelectSingleNode("kod_waluty").Value == "USD")
                    {
                    usd = float.Parse(nav.SelectSingleNode("kurs_sredni").Value);
                    }
                    if (nav.SelectSingleNode("kod_waluty").Value == "GBP")
                    {
                    gbp = float.Parse(nav.SelectSingleNode("kurs_sredni").Value);
                }
                    if (nav.SelectSingleNode("kod_waluty").Value == "EUR")
                    {
                    eur = float.Parse(nav.SelectSingleNode("kurs_sredni").Value);               }
            }
        }
        public Form1()
        {
            InitializeComponent();
            UpdatePr();
        }
        //Only numbers in textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checking if fields are empty
            if (this.comboBox1.SelectedItem == null || this.comboBox2.SelectedItem == null || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please complete this information.");
            }
            else
            {
                float amount = float.Parse(textBox1.Text);
                float rate = new float();
                float rate2 = new float();
                if (comboBox2.SelectedIndex == 0)
                    rate = usd;
                else if (comboBox2.SelectedIndex == 1)
                    rate = gbp;
                else if (comboBox2.SelectedIndex == 2)
                    rate = eur;
                else if (comboBox2.SelectedIndex == 3)
                    rate = 1;

                if (comboBox1.SelectedIndex == 0)
                    rate2 = usd;
                else if (comboBox1.SelectedIndex == 1)
                    rate2 = gbp;
                else if (comboBox1.SelectedIndex == 2)
                    rate2 = eur;
                else if (comboBox1.SelectedIndex == 3)
                    rate2 = 1;
                //PLN in combobox1
                if (this.comboBox1.SelectedIndex == 3)
                {
                    label1.Text = (amount / rate).ToString();
                }
                else
                {
                    float pom = amount * rate2;
                    label1.Text = (pom / rate).ToString();
                }
            }
        }
    }
}
