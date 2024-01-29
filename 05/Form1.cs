using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Vytvořte program, který bude ze seznamu obrázků náhodně vybírat jeden a zobrazovat v komponentě PictureBox.
        Při kliku na vybraný obrázek se obrázek smaže ze seznamu i z komponenty PictureBox.
        Obrázky si ulož do komponenty ImageLis. Bitmapy obrázků ulož do Listu.
        A dále již pracuj s Listem.
        */
        private List<Bitmap> list;
        private Random rnd;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int index = rnd.Next(0, list.Count);
            if (list.Count > 0)
            {
                pictureBox1.Image = list[index];
                list.RemoveAt(index);
            }
            else
            {
                pictureBox1.Image = null;
                MessageBox.Show("Žádný obrázek není k dispozici");
            }
                

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            list = new List<Bitmap>();

            list.Add(new Bitmap("images\\1.png"));
            list.Add(new Bitmap("images\\2.jpg"));
            list.Add(new Bitmap("images\\3.png"));
            list.Add(new Bitmap("images\\4.png"));
            list.Add(new Bitmap("images\\5.png"));

            int index = rnd.Next(0, list.Count);
            pictureBox1.Image = list[index];

        }
    }
}
