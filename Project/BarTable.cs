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
    public partial class BarTable : Form
    {
        public BarTable()
        {
            InitializeComponent();
            label1.Text = "Καλώς Ήρθατε! \n Παρακαλώ καθίστε και \n όποτε επιλέξετε θα είμαι εδώ \n να σας εξυπηρετήσω!";
            button3.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuView form = new MenuView();
            form.fromWhere = "bart";
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BarTable_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bar form2 = new Bar();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "BarTable");
            help form10 = new help();
            form10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            label1.Text = "Θα θέλατε να πληρώσετε \nμε κάρτα?";
            button4.Visible = true;
            button6.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label1.Text = "Ευχαριστούμε πολύ!\nελπίζω να τα βρήκατε \nόλα καλά!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            pictureBox3.Visible = true;
            button4.Visible = false;
            button6.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            timer1.Start();
            button4.Visible = false;
            button6.Visible = false;
            label1.Text = "Ευχαριστούμε πολύ!\nελπίζω να τα βρήκατε \nόλα καλά!";
        }

        private void button7_Click(object sender, EventArgs e)
        {            
            string reserveStatus = System.IO.File.ReadAllText("barres.txt");
            if (reserveStatus.Equals("yes"))
            {
                button7.Visible = false;
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
