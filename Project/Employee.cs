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
    public partial class Employee : Form
    {

        public Image bright = new Bitmap(Application.StartupPath + "/e.jpg");
        public Image dark = new Bitmap(Application.StartupPath + "/ee.jpg");
        public string d = "Dark";
        public string b = "Bright";
        public Employee()
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
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseSide form = new ChooseSide();
            form.Show();
            this.Close();
        }

        private void ticketPurchase_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BarEmployee form = new BarEmployee();
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "Employee");
            help form10 = new help();
            form10.Show();
        }
    }
}
