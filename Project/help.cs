using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAAY
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            string help = System.IO.File.ReadAllText("form.txt");
            help += ".txt";
            richTextBox1.Text = System.IO.File.ReadAllText(help);
            //richTextBox1.Text = System.IO.File.ReadAllText(form.txt .txt);
        }
    }
}
