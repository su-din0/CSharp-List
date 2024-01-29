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
//    Zadejte počet prvků aritmetické posloupnosti n první prvek a1 a diferenci d. 
//    Pomocí třídy List vytvořte seznam prvních n prvků aritmetické posloupnosti 
//    a seznam vypište. Vytvořte metodu, která k zadanému Listu přidá zadaný počet 
//    prvků aritmetické posloupnosti. Zavolejte metodu a seznam vypište.


namespace _06
{

    public partial class Form1 : Form
    {
        private void PridaniPrvku(List<int> list, int n, int a1, int d)
        {
            int prvek = a1;
            for (int i = list.Count(); i < n+list.Count(); i++)
            {
                prvek += d;
                list.Add(prvek);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int a1 = int.Parse(textBox2.Text);
            int d = int.Parse(textBox3.Text);

            List<int> list = new List<int>();
            int prvek = a1;
            for (int i = 0; i < n; i++)
            {
                prvek += d;
                list.Add(prvek);
            }
            for (int i = 0; i < list.Count(); i++)
            {
                listBox1.Items.Add(list[i]);
            }

            PridaniPrvku(list, 3, a1, d);
            for (int i = 0; i < list.Count(); i++)
            {
                listBox2.Items.Add(list[i]);
            }
        }
    }
}
