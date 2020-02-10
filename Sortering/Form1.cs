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
                Mergespilt(TalArray);
            }
        }
        private void AntalAfTal()
        {
            int.TryParse(txtTalindput.Text, out AntalTal);
            TalArray = new int[AntalTal];
            Sorteret = new int[AntalTal];
            Random rnd = new Random();
            for (int i = 0; i < TalArray.Length; i++)
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

            for (int i = 0; i < Sorteret.Length; i++)
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

        private int[] Mergespilt(int[] a)
        {
            int n = a.Length;
            if (n == 1)
            {
                return a;
            }

            int[] array1 = new int[a.Length / 2];
            int[] array2 = new int[a.Length / 2];

            for (int i = 0; i < (a.Length / 2) ; i++)
            {
                array1[i] = TalArray[i];
            }
            for (int i = 0; i < (a.Length /2) ; i++)
            {
                array2[i] = TalArray[i+(a.Length/2)];
            }
            array1 = Mergespilt(array1);
            array2 = Mergespilt(array2);

            return Merge(array1, array2);
        }

        private int[] Merge(int[] a, int[] b)
        {
            int TotalLength = a.Length + b.Length;
            int[] c = new int[TotalLength];

            int left = 0;
            int right = 0;
            int resultat = 0;

            while (left < a.Length || right < b.Length)
            {
                if (a[left] <= b[right])
                {
                    c[resultat] = a[left];
                    left++;
                    resultat++;
                }
                else if (left < a.Length)
                {
                    c[resultat] = a[left];
                    left++;
                    resultat++;
                }
                else if (right <= b.Length)
                {
                    c[resultat] = b[right];
                    right++;
                    resultat++;
                }
                else
                {
                    c[resultat] = b[right];
                    right++;
                    resultat++;
                }
            }
            return c;
        }
     }
}
