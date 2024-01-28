using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Načtěte do Listu n čísel z textového souboru cisla.txt. Vytvořte pro list metodu,
        která v Listu najde druhé maximální číslo a jeho pořadí.
        */

        private double DruheMax(List<double> list, out int index)
        {
            double max = double.MinValue;
            double druheMax = double.MinValue;

            index = -1;


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    druheMax = max;
                    max = list[i];

                    index = i;
                }
                else if (list[i] > druheMax)
                {
                    druheMax = list[i];

                    index = i;
                }
            }

            return druheMax;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("cisla.txt");
            List<double> cisla = new List<double>();
            while (!sr.EndOfStream)
            {
                int cislo = int.Parse(sr.ReadLine());
                cisla.Add(cislo);
            }
            
            sr.Close();

            int index;
            double druheMax = DruheMax(cisla, out index);

            MessageBox.Show($"Druhe nejvetsi cislo je {druheMax} a jeho index je {index}");

        }
    }
}
