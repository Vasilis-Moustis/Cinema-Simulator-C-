using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalAAY
{
    public partial class LoginForm : Form
    {
        List<Credentials> credentials = new List<Credentials>();
        public LoginForm()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            WebPortal form = new WebPortal();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1;
            string text2;
            bool found = false;

            foreach (Credentials cred in credentials)
            {
                text1 = cred.username;
                text2 = cred.password;
                if (textBox1.Text == text1 && textBox2.Text == text2)
                {
                    found = true;
                    web_interface form2 = new web_interface();
                    File.WriteAllText(Application.StartupPath + "/loggedin.txt", textBox1.Text);
                    form2.Show();
                    this.Hide();
                }
            }

            if (!found)
            {
                MessageBox.Show("Ο συνδυασμός στοιχείων είναι λανθασμένος!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            signUp form2 = new signUp();
            form2.Show();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "LoginForm");
            help form10 = new help();
            form10.Show();
        }
    }
}
