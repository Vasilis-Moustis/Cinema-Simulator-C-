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
    public partial class ChooseSide : Form
    {
        
        public ChooseSide()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.Show();
            this.Hide();
        }

        private void ChooseSide_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "ChooseSide");
            help form10 = new help();
            form10.Show();
        }
    }
}
