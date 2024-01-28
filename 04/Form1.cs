using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Po stisku tlačítka Ulož, program uloží větu z TextBox do List,
        poté se zpřístupní tlačítka s popisky a,e,i,o,u,y. Těmto tlačítkům napište společnou obsluhu,
        která bude po stisku mazat příslušná písmena z List a ihned List zobrazí do TextBoxu.
        Příslušné tlačítko se po akci znepřístupní. 
        */

        List<char> list = new List<char>();

        private void Smaz(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            char charToDelete = button.Text[0];

            list.RemoveAll(x => x == charToDelete);

            //1. způsob
            //textBox1.Text = string.Join("", list);

            /*
            2. způsob

            textBox1.Text = "";
            foreach (char znak in list)
            {
                textBox1.Text += znak;
            }*/

            button.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;

            list = veta.ToList();

            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Enabled = false;
            }
        }
    }
}
