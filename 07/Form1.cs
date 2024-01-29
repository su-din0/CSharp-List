using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Vytvořte seznam n náhodně vygenerovaných celých čísel z intervalu -3..6 včetně pomocí třídy List.
        Čísla ze seznamu List vypište do komponenty ListBox.
        Vytvořte metodu ZrusNulu, která ze zadaného seznamu vypustí všechna čísla s hodnotou nula.
        Napište metodu DruhyNejvetsi, která vrátí druhý největší prvek seznamu
        nepoužívejte vlastní cyklus, můžete měnit pořadí prvků.
        Zavolejte metody v programu a opravený seznam zobrazte
        */

        private List<int> Vygeneruj(int n)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int cislo = rnd.Next(-3, 7);
                list.Add(cislo);
            }
            return list;
        }

        private void Vypis(List<int> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (int i in list)
            {
                lb.Items.Add(i);
            }
        }

        private void ZrusNulu(List<int> list)
        {
            list.RemoveAll(x => x == 0);
        }

        private int DruhyNejvetsi(List<int> list)
        {
            //Hodil jsem to do pomocné proměnné, protože jsem nechtěl měnit pořadí prvků v originálním listu, ale to je asi jedno
            List<int> temp = new List<int>(list);
            temp = list.Distinct().ToList();
            temp.Sort();
            temp.Reverse();

            return temp[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            List<int> cisla = this.Vygeneruj(n);
            this.Vypis(cisla, listBox1);

            MessageBox.Show($"Druhy nejvetsi prvek je {this.DruhyNejvetsi(cisla)}");

            this.ZrusNulu(cisla);
            this.Vypis(cisla, listBox2);
        }
    }
}
