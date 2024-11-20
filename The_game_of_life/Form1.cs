using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_game_of_life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void rajzol(int x, int y)
        {
            Bitmap myBitmap = new Bitmap("600x600.bmp");
            

        }

        public Bitmap myBitmap = new Bitmap("600x600.bmp");
        public int x = 30;
        public int y = 30;
        public int[] pontok = new int[1000]; 
        private void button1_Click(object sender, EventArgs e)
        {

            
            pictureBox1.Image = myBitmap;
            Color c = myBitmap.GetPixel(30, 30);

            myBitmap.SetPixel(x, y, Color.Red);
            myBitmap.SetPixel(x, y + 1, Color.Red);
            myBitmap.SetPixel(x, y - 1, Color.Red);
            myBitmap.SetPixel(x + 1, y + 1, Color.Red);
            myBitmap.SetPixel(x + 1, y, Color.Red);
            myBitmap.SetPixel(x + 1, y - 1, Color.Red);
            myBitmap.SetPixel(x - 1, y, Color.Red);
            myBitmap.SetPixel(x - 1, y + 1, Color.Red);
            myBitmap.SetPixel(x - 1, y - 1, Color.Red);

            x += 2;
        }
    }
}
