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
    public partial class ConfirmAsVisitor : Form
    {
        public ConfirmAsVisitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox3.Text) || !String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Επιτυχής καταχώρηση κράτησης!");
                File.WriteAllText(Application.StartupPath + "/hasres.txt", "yes");
                File.WriteAllText(Application.StartupPath + "/loggedin.txt", textBox1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ελλειπή εισαγωγή στοιχείων");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
