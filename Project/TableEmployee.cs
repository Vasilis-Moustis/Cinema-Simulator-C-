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
    public partial class TableEmployee : Form
    {
        public TableEmployee()
        {
            InitializeComponent();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (!pictureBox2.Visible && !pictureBox3.Visible && !pictureBox4.Visible)
            {
                BarEmployee form = new BarEmployee();
                form.cleaned = true;
                form.Show();
                this.Close();
               
            }
           else
            {
                MessageBox.Show("Παρακαλώ τελειώσατε την διαδικασία\nκαθαρισμού των τραπεζιών!");
          
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void TableEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "TableEmployee");
            help form10 = new help();
            form10.Show();
        }
    }
}
