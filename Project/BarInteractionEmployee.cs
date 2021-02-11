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
    public partial class BarInteractionEmployee : Form
    {

        public decimal receipt = 0;


        public BarInteractionEmployee()
        {
            InitializeComponent();
            label1.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            timer1.Start();
                                   
        }

        private void BarInteractionEmployee_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Text = "Καλώς ήρθατε!";
            int[] order = new int[4];
            Random r = new Random();
            for (int i = 0; i < 4; i++)
                order[i] = r.Next(3) + 1;
            
            int num = r.Next(4);
            receipt = order[0] * 30 + order[1] * 26 + order[2] * 5 + order[3] * 18;
            receipt /= 10;
            switch(num)
            {
                case 0:
                    pictureBox1.Visible = true; 
                    label1.Text = "Χαίρεται, θα ήθελα " + order[0] + " popcorn,\n" + order[1] + " nachos, " + order[2] + " bottles of water and " + order[3] + " ice teas please.";
                    button1.Visible = true;
                    break;
                case 1:
                    pictureBox2.Visible = true;
                    label1.Text = "Χαίρεται, θα ήθελα " + order[0] + " popcorn,\n" + order[1] + " nachos, " + order[2] + " bottles of water and " + order[3] + " ice teas please.";
                    button1.Visible = true;
                    break;
                case 2:
                    pictureBox3.Visible = true;
                    label1.Text = "Χαίρεται, θα ήθελα " + order[0] + " popcorn,\n" + order[1] + " nachos, " + order[2] + " bottles of water and " + order[3] + " ice teas please.";
                    button1.Visible = true;
                    break;
                case 3:
                    pictureBox4.Visible = true;
                    label1.Text = "Χαίρεται, θα ήθελα " + order[0] + " popcorn,\n" + order[1] + " nachos, " + order[2] + " bottles of water and " + order[3] + " ice teas please.";
                    button1.Visible = true;
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            button1.Text = "Ετοιμάστε την παραγγελία...";
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Ετοιμάζεται...";
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            button2.Visible = false;
            label2.Text = "Το σύνολο σας είναι " + receipt + " ευρώ.";
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label2.Text = "";
            Random r2 = new Random();
            int debit = r2.Next(2);
            if (debit == 0)
            {
                label1.Text = "Θα ήθελα να πληρώσω με κάρτα παρακαλώ...";
                pictureBox6.Visible = true;
                timer4.Start();
                
            }
            else
            {
                label1.Text = "Θα ήθελα να πληρώσω με μετρητά παρακαλώ...";
                pictureBox7.Visible = true;
                timer6.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            pictureBox6.Visible = true;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            pictureBox6.Visible = false;
            label2.Text = "Ευχαριστόύμε πολύ,\n καλή σας διασκέδαση!";
            label1.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            timer1.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            pictureBox8.Visible = true;
            label2.Text = "Ορίστε τα ρέστα σας.";
            timer5.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BarEmployee form = new BarEmployee();
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "BarInteractionEmployee");
            help form10 = new help();
            form10.Show();
        }
    }
}
