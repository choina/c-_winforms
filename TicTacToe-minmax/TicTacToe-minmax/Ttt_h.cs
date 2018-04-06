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
            pole[3] = p4; pole[4] = p5; pole[5] = p6;
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
                pole[i].Image = Properties.Resources.raf;
                val_pol[i] = 'o';
                if (sprawdz('o', val_pol) == true) MessageBox.Show("Player O won");
                ai();
            }
        }
        public void ai()
        {
            int move = bestspot();
            pole[move].Image = Properties.Resources.ra;
            val_pol[move] = 'x';
            if(sprawdz('x', val_pol)==true) MessageBox.Show("Player X won");
        }
        public int bestspot()
        {
            return 1;
            //return minmax();
        }
        public bool sprawdz(char player, char [] tab)
        {
            if (
             ((tab[0] == player && tab[1] == player && tab[2] == player) ||
             (tab[3] == player && tab[4] == player && tab[5] == player) ||
             (tab[6] == player && tab[7] == player && tab[8] == player) ||
             (tab[0] == player && tab[3] == player && tab[6] == player) ||
             (tab[1] == player && tab[4] == player && tab[7] == player) ||
             (tab[2] == player && tab[5] == player && tab[8] == player) ||
             (tab[0] == player && tab[4] == player && tab[8] == player) ||
             (tab[2] == player && tab[4] == player && tab[6] == player))
             )
            {
                return true;
            }
            else return false;
        }
        public int minmax()
        {
            int a_spots = AvailSpots();
            char[] NewBoard = new char[9];
            NewBoard = val_pol;
            if (sprawdz('o', NewBoard) == true)
            {
                return -10;
            }
            else if (sprawdz('x', NewBoard) == true)
            {
                return 10;
            }
            else if(a_spots==0)
            {
                return 0;
            }
            return 0;
        }
        public int AvailSpots()
        {
            int n = new int();
            for(int i=0;i<9;i++)
            {
                n++;
            }
            return n;
        }
    }
}