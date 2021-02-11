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
    public partial class ElectricCleaner : Form
    {
        public ElectricCleaner()
        {
            InitializeComponent();
                        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CleanerControl form = new CleanerControl();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BarEmployee form2 = new BarEmployee();
            form2.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "ElectricCleaner");
            help form10 = new help();
            form10.Show();
        }
    }
}
