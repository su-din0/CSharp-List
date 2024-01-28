using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Napište metodu Vypis, která zadaný List vypíše do ListBoxu.
        Načtěte do Listu n náhodných celých čísel z intervalu 2..10 včetně, kde n je zadáno v TextBoxu a zavolejte metodu Vypis.
        Vypište pořadí prvního a posledního maximálního čísla
        Vyměňte první sudé minimální číslo s prvním prvkem Listu a zavolejte metodu Vypis.
        Z Listu smažte všechna maximální čísla a zavolejte metodu Vypis.
        */

        private void Vypis(List<int> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (int item in list)
            {
                lb.Items.Add(item);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            int n = int.Parse(textBox1.Text);
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(2, 11));
            }

            this.Vypis(list, listBox1);

            int max = int.MinValue;
            int prvniIndex = -1;
            int posledniIndex = -1;

            int prvniSude = 0;
            int prvniSudeIndex = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                    prvniIndex = i;
                }

                if (list[i] == max)
                {
                    posledniIndex = i; 
                }
                if (list[i] % 2 == 0)
                {
                    prvniSude = list[i];
                    prvniSudeIndex = i;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == max)
                {
                    if (prvniIndex == -1)
                    {
                        prvniIndex = i;
                    }
                    posledniIndex = i;
                }
            }

            MessageBox.Show($"První maximum je na pozici {prvniIndex+1}, poslední maximum je na pozici {posledniIndex+1}");


            if (prvniSudeIndex != -1)
            {
                list[prvniSudeIndex] = list[0];
                list[0] = prvniSude;
            }

            this.Vypis(list, listBox2);

            list.RemoveAll(x => x == max);

            this.Vypis(list, listBox3);
            
        }
    }
}
