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
    public partial class CleanerControl : Form
    {

        public string d = "Dark";
        public string b = "Bright";

        public CleanerControl()
        {
            InitializeComponent();
            richTextBox1.Visible = false;
            string lights = System.IO.File.ReadAllText("lights.txt");
            if (lights.Equals(d))
            {
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.BackColor = Color.Green;
            }
                        
        }

        private void CleanerControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElectricCleaner form = new ElectricCleaner();
            form.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            File.WriteAllText(Application.StartupPath + "/lights.txt", "Bright");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            File.WriteAllText(Application.StartupPath + "/lights.txt", "Dark");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cleaning form2 = new Cleaning();
            form2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible)
            {
                richTextBox1.Visible = false;
            }
            else
            {
                richTextBox1.Visible = true;
            }
            richTextBox1.LoadFile(Application.StartupPath + "/logs.txt", RichTextBoxStreamType.PlainText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "CleanerControl");
            help form10 = new help();
            form10.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/logs.txt", "");
            richTextBox1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManualCleaner form0 = new ManualCleaner();
            form0.Show();
            this.Close();
        }
    }
    }

