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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox2.Text && textBox3.Text != "" && textBox1.Text != "" && textBox5.Text != "" && textBox2.Text != "")
            {
                TextWriter writes1 = new StreamWriter("list_of_users.txt", true);
                writes1.WriteLine(textBox3.Text + "   " + textBox1.Text + "   " + textBox5.Text + "   " + textBox2.Text);
                writes1.Close();
                WebPortal form = new WebPortal();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong check if you filled the boxes and if your passwords match");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Close();
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "SignUp");
            help form10 = new help();
            form10.Show();
        }
    }
}
