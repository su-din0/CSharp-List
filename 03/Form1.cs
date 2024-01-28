using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Načtěte do Listu n náhodných reálných čísel z intervalu <-6,25), kde n je zadáno v TextBoxu.
        Zavolejte metodu Vypis, která čísla vypíše do daného ListBoxu.
        Proveďte reverzi Listu a zavolejte metodu Vypis. Do dalšího ListBoxu vypište pořadí všech minimálních čísel.
        */

        private void Vypis(List<double> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (var item in list)
            {
                lb.Items.Add(item);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<double> list = new List<double>();

            Random rnd = new Random();

            int n = int.Parse(textBox1.Text);
            
            for (int i = 0; i < n; i++)
            {
                double nahodneCislo = rnd.NextDouble() * (25 - (-6)) + (-6);
                list.Add(nahodneCislo);
            }

            Vypis(list, listBox1);

            list.Reverse();

            Vypis(list, listBox2);

            double min = list.Min();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == min)
                {
                    listBox3.Items.Add(i+1);
                }
            }
        }
    }
}
