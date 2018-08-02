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
        private const string code = "kod_waluty";
        public static string Code => code;
        List<float> list = new List<float>(); //List with currency exchange rates
        int[] table_list = new int[5];


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
                    if(nav.SelectSingleNode(Code).Value == "USD")
                    {
                    list.Insert(0, float.Parse(nav.SelectSingleNode("kurs_sredni").Value));
                    //0 = USD
                    }
                    if (nav.SelectSingleNode(Code).Value == "EUR")
                    {
                    list.Insert(1, float.Parse(nav.SelectSingleNode("kurs_sredni").Value));
                    //1 = EUR
                    }
                    if (nav.SelectSingleNode(Code).Value == "GBP")
                    {
                    list.Insert(2, float.Parse(nav.SelectSingleNode("kurs_sredni").Value));
                    //2 = GBP
                    }
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

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
                float rate1 = 1;
                float rate2 = 1;

                if (comboBox1.SelectedIndex == comboBox1.FindStringExact("USD"))
                {
                    rate1 = list[0];
                }
                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("EUR"))
                {
                    rate1 = list[1];
                }
                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("GBP"))
                {
                    rate1 = list[2];
                }




                if (comboBox2.SelectedIndex == comboBox1.FindStringExact("USD"))
                {
                    rate2 = list[0];
                }
                else if (comboBox2.SelectedIndex == comboBox1.FindStringExact("EUR"))
                {
                    rate2 = list[1];
                }
                else if (comboBox2.SelectedIndex == comboBox1.FindStringExact("GBP"))
                {
                    rate2 = list[2];
                }


                //PLN in comboBox1
                if (this.comboBox1.SelectedIndex == 3)
                {
                    label1.Text = (amount / rate2).ToString();
                }

                else
                {
                    float pom = amount * rate1;
                    label1.Text = (pom / rate2).ToString();
                }
            }
        }
    }
}
