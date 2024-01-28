using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Zadejte počet prvků geometrické posloupnosti n první dva prvky a1, a2.
        Pomocí třídy List vytvořte seznam prvních n prvků geometrické posloupnosti a seznam vypište.
        Vytvořte metodu, která pro zadaný List a zadaný počet prvků p posloupnosti zjistí,
        zda list obsahuje dostatečný počet prvků a spočítá součet prvních p prvků.
        Metodu zavolejte a vypište výsledek.
        */

        private List<double> PrvnichN(double a1, double a2, int n)
        {
            List<double> list = new List<double>();
            double q = a2 / a1;
            double nPrvek = a1;

            list.Add(nPrvek);
            for (int i = 0; i < n; i++)
            {
                nPrvek *= q;
                list.Add(nPrvek);
            }

            return list;
        }

        private bool ObsahujeDostatecnyPocetPrvku(List<double> list, int p, out double soucet)
        {
            soucet = 0;
            if (list.Count < p) return false;
            
            for (int i = 0; i < p; i++)
            {
                soucet += list[i];
            }
            
            return true;
        }

        private void Vypis(List<double> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (double item in list)
            {
                lb.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            double a1 = double.Parse(textBox2.Text);
            double a2 = double.Parse(textBox3.Text);
            int p = int.Parse(textBox4.Text);

            List<double> list = this.PrvnichN(a1, a2, n);

            this.Vypis(list, listBox1);

            if (this.ObsahujeDostatecnyPocetPrvku(list, p, out double soucet)) MessageBox.Show($"Součet prvních {p} prvků je {soucet}");
            else MessageBox.Show("List neobsahuje dostatečný počet prvků");
        }
    }
}
