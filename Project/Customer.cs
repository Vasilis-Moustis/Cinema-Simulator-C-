using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FinalAAY
{
    public partial class Customer : Form
    {

        public Image bright = new Bitmap(Application.StartupPath + "/e.jpg");
        public Image dark = new Bitmap(Application.StartupPath + "/ee.jpg");
        public string d = "Dark";
        public string b = "Bright";
        public string lights;

        public bool reserved = false;

        public Customer()
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

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            TicketSupplier form = new TicketSupplier();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lights.Equals(d))
            {
                //this.BackgroundImage = dark;
                MessageBox.Show("Συγχωρέστε μας είμαστε κλειστά!");
            }
            else
            {
                //this.BackgroundImage = bright;
                TicketSupplier form = new TicketSupplier();
                form.Show();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string res = System.IO.File.ReadAllText("hasres.txt");
            if (res.Equals("yes"))
                reserved = true;

            if (reserved)
            {
                MessageBox.Show("Έχετε ήδη πραγματοποιήσει κράτηση. \nΠροχωρήστε στο ταμείο ώστε \nνα παραλάβετε τα εισητήριά σας!");
            }
            else
            { 
                WebPortal form = new WebPortal();
                form.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "Customer");
            help form10 = new help();
            form10.Show();
        }
    }
}
