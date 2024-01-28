using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Ve víceřádkové komponentě TextBox jsou zapsány znaky, v každém řádku jeden znak.
        Vytvořte seznam znaků z TextBox pomocí třídy List. Znaky z List vypište do komponenty ListBox.
        Ze seznamu List vypusťte všechna malá písmena anglické abecedy a všechny číslice.
        Opravený seznam zobrazte.
        */

        private void Vypis(List<char> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (char c in list)
            {
                lb.Items.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<char> list = new List<char>();
            foreach (string s in textBox1.Lines)
            {
                list.Add(s[0]);
            }

            this.Vypis(list, listBox1);

            //1. způsob
            list.RemoveAll(x => char.IsLower(x) || char.IsDigit(x));
            this.Vypis(list, listBox2);

            /*
            2. způsob
            int i = 0;
            while (i < list.Count)
            {
                if (char.IsLower(list[i]) || char.IsDigit(list[i])) list.RemoveAt(i);
                else i++;
            }

            this.Vypis(list, listBox2);
            */
        }
    }
}
