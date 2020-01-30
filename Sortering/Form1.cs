using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Sortering
{
    public partial class Form1 : Form
    {
        int AntalTal;
        int[] TalArray;
        int[] Sorteret;
        bool Bubble = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            lstSorteretTal.Items.Clear();
            if (cbnGenerettal.Checked == false)
            {
                lstGeneretTal.Items.Clear();
                AntalAfTal();
            }
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
            Sorteret = new int[AntalTal];
            Random rnd = new Random();
            for (int i = 0; i < TalArray.Length-1; i++)
            {
                TalArray[i] = rnd.Next(1, 500);
                Sorteret[i] = TalArray[i];
                lstGeneretTal.Items.Add(TalArray[i]);
            }
            
        }

        private void Bubblesort()
        {
            Stopwatch Tid = new Stopwatch(); //funktion fra https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.elapsed?view=netframework-4.8&fbclid=IwAR1eGBTJ-f5wk82Z5UMzgY_NEWFbyGWbVd3agGpH9-o29gaY-TVegAPjSxE
            if (cbnGenerettal.Checked == true)
            {
                for (int i = 0; i < Sorteret.Length; i++)
                {
                    Sorteret[i] = TalArray[i];
                }
            }
            int cycles = 0;
            Tid.Start();

            for (int j = 0; j < Sorteret.Length; j++) //fået hjælp af michael til at forstå hvorfor der skal være 2 loops
            {
                for (int i = 0; i < Sorteret.Length - 1; i++)
                {
                    if (Sorteret[i] > Sorteret[i + 1])
                    {
                        int temp = Sorteret[i + 1];
                        Sorteret[i + 1] = Sorteret[i];
                        Sorteret[i] = temp;
                    }
                cycles++;
                }
            }
            Tid.Stop();

            for (int i = 1; i < Sorteret.Length; i++)
            {
                lstSorteretTal.Items.Add(Sorteret[i]);
            }
            txtCycles.Text = cycles.ToString();
            txtTime.Text = ((Tid.Elapsed.TotalMilliseconds).ToString());

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
