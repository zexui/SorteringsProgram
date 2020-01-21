using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortering
{
    public partial class Form1 : Form
    {
        int AntalTal;
        int[] TalArray;
        bool Bubble = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            AntalAfTal();
            if (Bubble == true)
            {
                Bubblesort();
            }
            else if (Bubble == false)
            {

            }
        }
        private void AntalAfTal()
        {
            int.TryParse(txtTalindput.Text, out AntalTal);
            TalArray = new int[AntalTal];
            Random rnd = new Random();
            for (int i = 0; i < TalArray.Length-1; i++)
            {
                TalArray[i] = rnd.Next(1, 500);
                lstGeneretTal.Items.Add(TalArray[i]);
            }
        }

        private void Bubblesort()
        {
            for (int i2 = 0; i2 < TalArray.Length; i2++) //fået hjælp af michael til at forstå hvorfor der skal være 2 loops
            {
                for (int i = 0; i < TalArray.Length - 1; i++)
                {
                    if (TalArray[i] > TalArray[i + 1])
                    {
                        int temp = TalArray[i + 1];
                        TalArray[i + 1] = TalArray[i];
                        TalArray[i] = temp;
                    }
                }
            }
            for (int i = 1; i < TalArray.Length; i++)
            {
                lstSorteretTal.Items.Add(TalArray[i]);
            }
        }

        private void RbnBubble_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnBubble.Checked == true)
            {
                Bubble = true;
            }
        }
        private void RbnMerge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMerge.Checked == true)
            {
                Bubble = false;
            }
        }
    }
}
