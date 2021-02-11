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
    public partial class BarEmployee : Form
    {

        public bool cleaned = false;

        public Image bright = new Bitmap(Application.StartupPath + "/fb.jpg");
        public Image dark = new Bitmap(Application.StartupPath + "/fbe.jpg");
        public string d = "Dark";
        public string b = "Bright";
        public string lights;

        public BarEmployee()
        {
            InitializeComponent();
            lights = System.IO.File.ReadAllText("lights.txt");
            if (lights.Equals(d))
            {
                this.BackgroundImage = dark;
            }
            else
            {
                this.BackgroundImage = bright;
            }
                        
        }

        private void BarEmployee_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lights.Equals(d))
            {
                //this.BackgroundImage = dark;
                MessageBox.Show("Παρακαλώ ανοίξτε τα φώτα!");
            }
            else
            {
               //this.BackgroundImage = bright;
                BarInteractionEmployee form = new BarInteractionEmployee();
                form.Show();
                this.Close();
            }            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ElectricCleaner form3 = new ElectricCleaner();
            form3.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lights.Equals(d))
            {
                //this.BackgroundImage = dark;
                MessageBox.Show("Παρακαλώ ανοίξτε τα φώτα!");
            }
            else
            {
                //this.BackgroundImage = bright;
                if (!cleaned)
                {
                    TableEmployee form2 = new TableEmployee();
                    form2.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Η διαδικασία καθαρισμού έχει ολοκληρωθεί ήδη!");
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee form4 = new Employee();
            form4.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "BarEmployee");
            help form10 = new help();
            form10.Show();
        }
    }
}
