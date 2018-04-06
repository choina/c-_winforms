using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_minmax
{
    public partial class Form1 : Form
    {
        Ttt_h game;
        public Form1()
        {
            InitializeComponent();
            game = new Ttt_h(pole0, pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8);
        }

        private void pole0_Click(object sender, EventArgs e)
        {
            game.ruch(0);
        }

        private void pole1_Click(object sender, EventArgs e)
        {
            game.ruch(1);
        }

        private void pole2_Click(object sender, EventArgs e)
        {
            game.ruch(2);
        }

        private void pole3_Click(object sender, EventArgs e)
        {
            game.ruch(3);
        }

        private void pole4_Click(object sender, EventArgs e)
        {
            game.ruch(4);
        }

        private void pole5_Click(object sender, EventArgs e)
        {
            game.ruch(5);
        }

        private void pole6_Click(object sender, EventArgs e)
        {
            game.ruch(6);
        }

        private void pole7_Click(object sender, EventArgs e)
        {
            game.ruch(7);
        }

        private void pole8_Click(object sender, EventArgs e)
        {
            game.ruch(8);
        }
    }
}
