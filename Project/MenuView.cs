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
    public partial class MenuView : Form
    {

        public string fromWhere;

        public decimal Price;
        public MenuView()
        {
            InitializeComponent();
            button3.Visible = false;
            button2.Visible = false;
        }

        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Price = numericUpDown1.Value * 30 + numericUpDown2.Value * 26 + numericUpDown3.Value * 22 + numericUpDown4.Value * 38 + numericUpDown5.Value * 45 + numericUpDown6.Value * 35
                + numericUpDown7.Value * 25 + numericUpDown8.Value * 11 + numericUpDown9.Value * 5 + numericUpDown10.Value * 18;
            Price /= 10;
            if (Price != 0)
            {
                button3.Visible = true;
                button2.Visible = true;
                label11.Text = "Το σύνολο της παραγγελίας σας είναι " + Price.ToString() +" ευρώ." +"\n Θέλετε να επιβεβαιώσετε την παραγγελία;"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Visible = false;
            label11.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fromWhere.Equals("bart"))
            {
                BarTable otherform = new BarTable();
                otherform.Show();
                otherform.label1.Text = "Το σύνολο σας είναι " + Price.ToString() + " ευρώ. " ;
                otherform.button3.Visible = true;
                otherform.button7.Visible = false;
                this.Close();
            }
            else if (fromWhere.Equals("bari"))
            {
                BarInteraction otherform2 = new BarInteraction();
                otherform2.Show();
                otherform2.label1.Text = "Το σύνολο σας είναι " + Price.ToString() + " ευρώ.";
                otherform2.button1.Visible = true;
                otherform2.button2.Visible = true;
                otherform2.label2.Visible = true;
                otherform2.button4.Visible = false;
                otherform2.button6.Visible = false;
                this.Close();
            }
            else if (fromWhere.Equals("user"))
            {
                MessageBox.Show("Επιτυχής καταχώρηση κράτησης εισητηρίων και παραγγελίας!");
                File.WriteAllText(Application.StartupPath + "/barres.txt", "yes");
                this.Close();
            }
            else
            {
                MessageBox.Show("Επιτυχής καταχώρηση κράτησης στο μπαρ!");
                File.WriteAllText(Application.StartupPath + "/barres.txt", "yes");
                ConfirmAsVisitor c = new ConfirmAsVisitor();
                c.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fromWhere.Equals("bart"))
            {
                BarTable otherform = new BarTable();
                otherform.Show();
                this.Close();
            }
            else if (fromWhere.Equals("bari"))
            {
                BarInteraction otherform2 = new BarInteraction();
                otherform2.Show();
                this.Close();
            }
            else if (fromWhere.Equals("user"))
            {
                MessageBox.Show("Δεν πραγματοποιήθηκε κράτηση στο  μπαρ!");
                File.WriteAllText(Application.StartupPath + "/barres.txt", "no");
                this.Close();
            }
            else
            {
                MessageBox.Show("Δεν πραγματοποιήθηκε κράτηση στο  μπαρ!");
                File.WriteAllText(Application.StartupPath + "/barres.txt", "no");
                ConfirmAsVisitor c = new ConfirmAsVisitor();
                c.Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/form.txt", "MenuView");
            help form10 = new help();
            form10.Show();
        }
    }
}
