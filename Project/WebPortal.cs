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
    public partial class WebPortal : Form
    {
        public WebPortal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/loggedin.txt", "");
            web_interface form = new web_interface();
            form.Show();
            this.Hide();
        }

        private void WebPortal_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "WebPortal");
            help form10 = new help();
            form10.Show();
        }
    }
}
