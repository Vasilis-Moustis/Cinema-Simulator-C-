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
    public partial class web_interface : Form
    {

        public web_interface()
        {
            InitializeComponent();
        }

        private void web_interface_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/movie.txt", "I Origins");
            Confirmation form = new Confirmation();
            form.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/movie.txt", "The Pantom of the Opera");
            Confirmation form = new Confirmation();
            form.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/movie.txt", "Marvel : The Avengers");
            Confirmation form = new Confirmation();
            form.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/movie.txt", "Hobbit");
            Confirmation form = new Confirmation();
            form.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/movie.txt", "Back to the Future");
            Confirmation form = new Confirmation();
            form.Show();
            this.Hide();
        }
    }
}
