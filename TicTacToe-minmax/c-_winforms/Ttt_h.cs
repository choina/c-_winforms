using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_minmax
{
    class Ttt_h
    {
        PictureBox[] pole = new PictureBox[9];
        public const char humanPlayer = 'o';
        public const char aihumanPlayer = 'x';
        char[] val_pol = new char[9];
        public Ttt_h(PictureBox p1, PictureBox p2, PictureBox p3, PictureBox p4, PictureBox p5, PictureBox p6, PictureBox p7, PictureBox p8, PictureBox p9)
        {
            pole[0] = p1; pole[1] = p2; pole[2] = p3;
            pole[3] = p4; pole[4] = p5; pole[5] = p7;
            pole[6] = p7; pole[7] = p8; pole[8] = p9;
            //WARTOŚĆ POLA: | N-NIC | X-KRZYZYK | O-KOLKO
            for (int i = 0; i < 9; i++)
            {
                val_pol[i] = 'n';
            }
        }
        public void ruch(int i)
        {
            if (val_pol[i] == 'n')
            {
                switch (i)
                {
                    case 0:
                        pole[0].Image = Properties.Resources.raf;
                        val_pol[i] = 'o';
                        break;
                    case 1:
                        pole[1].Image = Properties.Resources.raf;
                        val_pol[i] = 'o';
                        break;
                    case 2:
                        pole[2].Image = Properties.Resources.raf;
                        val_pol[i] = 'o';
                        break;
                }
                val_pol[i] = 'o';
            }
        }

        public void sprawdz(char player)
        {
            if (
             ((val_pol[0] == player && val_pol[1] == player && val_pol[2] == player) ||
             (val_pol[3] == player && val_pol[4] == player && val_pol[5] == player) ||
             (val_pol[6] == player && val_pol[7] == player && val_pol[8] == player) ||
             (val_pol[0] == player && val_pol[3] == player && val_pol[6] == player) ||
             (val_pol[1] == player && val_pol[4] == player && val_pol[7] == player) ||
             (val_pol[2] == player && val_pol[5] == player && val_pol[8] == player) ||
             (val_pol[0] == player && val_pol[4] == player && val_pol[8] == player) ||
             (val_pol[2] == player && val_pol[4] == player && val_pol[6] == player))
             )
            {
                MessageBox.Show("Wygrał:" + player.ToString());
            }
        }
    }
}