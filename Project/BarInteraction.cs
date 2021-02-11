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
    public partial class BarInteraction : Form
    {
        public BarInteraction()
        {
            InitializeComponent();
            label1.Text = "Καλώς ήρθατε στο bar του σινεμά μας.\n" +
                "Παρακαλώ ρίξτε μια ματιά στο μενού και \n " +
                "πείτε μου μόλις αποφασίσεται !";
            pictureBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
                        
        }

        private void BarInteraction_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuView form = new MenuView();
            form.fromWhere = "bari";
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            label2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Text = "";
            button3.Visible = true;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Ευχαριστούμε πολύ!\n Καλή σας διασκέδαση!";
            pictureBox2.Visible = false;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            label1.Text = "Ευχαριστούμε πολύ!\n Καλή σας διασκέδαση!";
            button3.Visible = false;
            button4.Visible = true;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bar form2 = new Bar();
            form2.Show();
            this.Hide();
            form2.thatsenough = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "BarInteraction");
            help form10 = new help();
            form10.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label2.Text = "Ορίστε τα ρέστα και η παραγγελία σας...";
            label2.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            timer1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string reserveStatus = System.IO.File.ReadAllText("barres.txt");
            if (reserveStatus.Equals("yes"))
            {
                button6.Visible = false;
                label1.Text = "H παραγγελία σας βρέθηκε!\nΕυχαριστούμε πολύ!\n Καλή σας διασκέδαση!";
                File.WriteAllText(Application.StartupPath + "/barres.txt", "no");
            }
            else
            {
                MessageBox.Show("Με συγχωρείτε δεν βλέπω καμία κράτηση...");
            }
        }
    }
}
