using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Vytvořte seznam n náhodně vygenerovaných celých čísel z intervalu -100..100 včetně pomocí třídy List.
        Čísla ze seznamu vypište do komponenty ListBox. Napište metodu,
        která v zadaném List prohodí minimum z lichých čísel dělitelných 3 a maximum ze sudých čísel.
        Metodu zavolejte a opravený seznam vypište.
        */

        private void Vypis(List<int> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (int i in list)
            {
                lb.Items.Add(i);
            }
        }

        //1. způsob
        private void Prohod(List<int> list)
        {
            int min = 100;
            int max = -100;
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0 && list[i] > max)
                {
                    max = list[i];
                    maxIndex = i;
                }
                if (list[i] % 2 != 0 && list[i] < min && list[i] % 3 == 0)
                {
                    min = list[i];
                    minIndex = i;
                }
            }
            list[minIndex] = max;
            list[maxIndex] = min;
        }

        /*
        2. způsob
        private List<int> Prohod2(List<int> list)
        {
            int min = 100;
            int max = -100;
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0 && list[i] > max)
                {
                    max = list[i];
                    maxIndex = i;
                }
                if (list[i] % 2 != 0 && list[i] < min && list[i] % 3 == 0)
                {
                    min = list[i];
                    minIndex = i;
                }
            }
            list[minIndex] = max;
            list[maxIndex] = min;
            return list;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            int n = int.Parse(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(-100, 101));
            }
            
            this.Vypis(list, listBox1);

            this.Prohod(list);

            this.Vypis(list, listBox2);
        }
    }
}
