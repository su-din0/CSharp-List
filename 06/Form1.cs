using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Zadejte počet prvků aritmetické posloupnosti n první prvek a1 a diferenci d.
        Pomocí třídy List vytvořte seznam prvních n prvků aritmetické posloupnosti a seznam vypište.
        Vytvořte metodu, která k zadanému Listu přidá zadaný počet prvků aritmetické posloupnosti.
        Zavolejte metodu a seznam vypište.
        */

        private void Vypis(List<int> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (int i in list)
            {
                lb.Items.Add(i);
            }
        }

        private void PridejPrvky(List<int> list, int pocet, int d)
        {
            int last = list[list.Count - 1];
            for (int i = 0; i < pocet; i++)
            {
                int next = last + d;
                list.Add(next);
                last = next;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int a1 = int.Parse(textBox2.Text);
            int d = int.Parse(textBox3.Text);

            List<int> list = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                int prvekN = a1 + i * d;
                list.Add(prvekN);
            }

            this.Vypis(list, listBox1);

            this.PridejPrvky(list, 5, d);

            this.Vypis(list, listBox2);

        }
    }
}
