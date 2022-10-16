using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HKBhatiaAssignment1
{
    public partial class Form1 : Form
    {

        bool chance = true;//checks for x or o turn
        bool checkwinner = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void play(object sender, EventArgs e)
        {
            Button i = (Button)sender;

                if (chance)
                {
                    i.Image = Properties.Resources.ImageX;
                    i.Tag = "1";
                }
                else
                {
                    i.Image = Properties.Resources.ImageO;
                    i.Tag = "2";
                }
                chance = !chance;
                i.Enabled = false;

                winner();
            
                       
        }


        private void winner()
        {

            if (B1.Tag == B2.Tag && B2.Tag == B3.Tag && !B1.Enabled)
                checkwinner = true;
            else if (B4.Tag == B5.Tag && B5.Tag == B6.Tag && !B4.Enabled)
                checkwinner = true;
            else if (B7.Tag == B8.Tag && B8.Tag == B9.Tag && !B7.Enabled)
                checkwinner = true;
            else if (B1.Tag == B4.Tag && B4.Tag == B7.Tag && !B1.Enabled)
                checkwinner = true;
            else if (B2.Tag == B5.Tag && B5.Tag == B8.Tag && !B2.Enabled)
                checkwinner = true;
            else if (B3.Tag == B6.Tag && B6.Tag == B9.Tag && !B3.Enabled)
                checkwinner = true;
            else if (B1.Tag == B5.Tag && B5.Tag == B9.Tag && !B1.Enabled)
                checkwinner = true;
            else if (B3.Tag == B5.Tag && B5.Tag == B7.Tag && !B3.Enabled)
                checkwinner = true;
            
            if(checkwinner)
            {
                String player = "";
                if (chance)
                    player = "O";
                else
                    player = "X";

                MessageBox.Show(player + " wins the game.");
            }

            if(checkwinner)
                gamereset();

        }

        private void gamereset()
        {
            checkwinner = false;
            chance = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            B4.Enabled = true;
            B5.Enabled = true;
            B6.Enabled = true;
            B7.Enabled = true;
            B8.Enabled = true;
            B9.Enabled = true;
            B1.Image = null;
            B2.Image = null;
            B3.Image = null;
            B4.Image = null;
            B5.Image = null;
            B6.Image = null;
            B7.Image = null;
            B8.Image = null;
            B9.Image = null;
            B1.Tag = "1";
            B2.Tag = "2";
            B3.Tag = "3";
            B4.Tag = "4";
            B5.Tag = "5";
            B6.Tag = "6";
            B7.Tag = "7";
            B8.Tag = "8";
            B9.Tag = "9";


        }
        
       
    }

}
