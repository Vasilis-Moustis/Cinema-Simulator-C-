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
    public partial class TicketSupplier : Form
    {

        List<Credentials> credentials = new List<Credentials>();

        public static Boolean bought = false;

        public decimal totalPrice;

        public TicketSupplier()
        {
            InitializeComponent();
            label1.Text = "Γεια χαρά!";
            string[] strAllLines = System.IO.File.ReadAllLines("list_of_users.txt");
            for (int i = 0; i < strAllLines.Length; i++)
            {
                Credentials cred = new Credentials();
                string[] temp = strAllLines[i].Split(new string[] { "   " }, StringSplitOptions.None);
                cred.username = temp[1];
                cred.password = temp[3];
                credentials.Add(cred);
            }
                        
        }
     
        private void TicketSupplier_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button4.Visible = false;
            comboBox1.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            numericUpDown1.Visible = false;
            textBox1.Visible = false;
            radioButton1.Visible = false;
            button7.Visible = false; ;
            button8.Visible = false;
            button9.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button11.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!bought)
            {
                Customer form = new Customer();
                form.Show();
                this.Close();
            }
            else
            {
                File.WriteAllText(Application.StartupPath + "hasres.txt", "no");
                Bar form2 = new Bar();
                form2.Show();
                bought = false;
                this.Close();
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            string reserveStatus = System.IO.File.ReadAllText("hasres.txt");
            if (reserveStatus.Equals("yes"))
            {
                textBox1.Visible = true;
                button11.Visible = true;
            }
            else
            {
                MessageBox.Show("Με συγχωρείτε δεν βλέπω καμία κράτηση...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button4.Visible = true;
            button3.Visible = false;
            label1.Text = "Υπάρχει μήπως κάποια κράτηση;";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Παρακαλώ επιλέξτε την ταινία που θέλετε!";
            button1.Visible = false;
            button4.Visible = false;
            comboBox1.Visible = true;
            button5.Visible = true;            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {   if (comboBox1.Text == "I Origins" || comboBox1.Text == "The Phantom of the Opera" || comboBox1.Text == "Marvel : The Avengers" || comboBox1.Text == "Hobbit" || comboBox1.Text == "Back to the Future")
            {
                label1.Text = "Πόσα εισιτήρια θα θέλατε για την ταινία " + comboBox1.SelectedValue;
                comboBox1.Visible = false;
                button5.Visible = false;
                button6.Visible = true;
                numericUpDown1.Visible = true;
                radioButton1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (comboBox1.Text != "")
            {
                MessageBox.Show("...");
            }
            else
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ταινία");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked && numericUpDown1.Value > 0)
            {
                totalPrice = 35 * numericUpDown1.Value;
                totalPrice /= 10;
                button6.Visible = false;
                numericUpDown1.Visible = false;
                radioButton1.Visible = false;
                button7.Visible = true;
                button7.Text = "Αγορά και παράδωση αποδείξεων για μειωμένο εισιτήριο";
                label1.Text = "Το σύνολό σας είναι " + totalPrice + " ευρώ!";
            }
            else if (numericUpDown1.Value > 0)
            {
                totalPrice = 55 * numericUpDown1.Value;
                totalPrice /= 10;
                button6.Visible = false;
                numericUpDown1.Visible = false;
                radioButton1.Visible = false;
                button7.Visible = true;
                label1.Text = "Το σύνολό σας είναι " + totalPrice + " ευρώ!";
            }
            else
            {
                MessageBox.Show("Παρακαλώ επιλέξατε τον αριθμό εισιτηρίων προς αγορά");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Θα θέλατε  να πληρώσετε με κάρτα;";
            button8.Visible = true;
            button9.Visible = true;
            button7.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button9.Visible = false;
            pictureBox1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "Ευχαριστούμε πολύ! Ορίστε τα ρέστα και τα \n εισιτήρια σας...Καλή σας διασκέδαση!";
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            bought = true;
            pictureBox4.Visible = true;
            button2.Text = "Μετάβαση στο bar...";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button9.Visible = false;
            pictureBox3.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label1.Text = "Ευχαριστούμε πολύ! Ορίστε τα εισιτήρια σας...\n Καλή σας διασκέδαση!";
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            bought = true;
            button2.Text = "Μετάβαση στο bar...";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "TicketSupplier");
            help form10 = new help();
            form10.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            button11.Visible = false;
            textBox1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string reserve = System.IO.File.ReadAllText("loggedin.txt");
            

            if (textBox1.Text == reserve)
                {
                    File.WriteAllText(Application.StartupPath + "/hasres.txt", "no");
                    label1.Text = "Ορίστε τα εισιτήρια σας. \nΚαλή διασκέδαση!";
                    button4.Visible = false;
                    button1.Visible = false;
                    pictureBox4.Visible = true;
                    bought = true;
                    button2.Text = "Μετάβαση στο bar...";
                }
            
        }
    }
}