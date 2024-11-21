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
        public int[,] matrix = new int[200,200];
        
        public void kezdetek()
        {
            Point K1 = new Point(10,15);
            Point K2 = new Point(10,16);
            Point K3 = new Point(11,16);
            Point K4 = new Point(9,17);



            kirajzol(K1);
            kirajzol(K2);
            kirajzol(K3);
            kirajzol(K4);
        }
        public void kirajzol(Point pont)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myBitmap.SetPixel(3 * pont.X + i, 3 * pont.Y + j, Color.Black);
                }
            }
            pictureBox1.Image = myBitmap;
        }
        /* szabalyok:
        nincs szomszed -> 0
        5 + szomszéd -> tulnep -> 0
        1 % 5 ->  nő matrix[x,y] + 1
        matrix -> bmp
        matrix ->  
         
         
         
         
         */






        private void button1_Click(object sender, EventArgs e)
        {

            kezdetek();
            pictureBox1.Image = myBitmap;

            /*
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
            */
        }
    }
}
