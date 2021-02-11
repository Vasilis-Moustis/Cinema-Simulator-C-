using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAAY
{
    public partial class Bar : Form
    {
        public int thatsenough = 0;

        public Image bright = new Bitmap(Application.StartupPath + "/fb.jpg");
        public Image dark = new Bitmap(Application.StartupPath + "/fbe.jpg");
        public string d = "Dark";
        public string b = "Bright";
        public Bar()
        {
            InitializeComponent();
            string lights = System.IO.File.ReadAllText("lights.txt");
            if (lights.Equals(d))
            {
                this.BackgroundImage = dark;
            }
            else
            {
                this.BackgroundImage = bright;
            }
            File.WriteAllText(Application.StartupPath + "hasres.txt", "");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            BarInteraction form = new BarInteraction();
            form.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BarTable form2 = new BarTable();
            form2.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(thatsenough < 3)
            {
                MessageBox.Show("What a relief!");
                thatsenough++;
            }
            else
            {
                MessageBox.Show("i went there 3 times i think thats enough");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MovieNight form3 = new MovieNight();
            form3.Show();
            this.Close();
        }

        private void Bar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "Bar");
            help form10 = new help();
            form10.Show();
        }
    }
}
