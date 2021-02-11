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
    public partial class Confirmation : Form
    {

        public int seatsSelected;
        string red = Application.StartupPath + "/red.jpg";
        string green = Application.StartupPath + "/green.jpg";

        public Confirmation()
        {
            InitializeComponent();
            monthCalendar1.MinDate = DateTime.Today;
            web_interface form = new web_interface();
            string movie = System.IO.File.ReadAllText("movie.txt");
            label5.Text = movie;            
            

            pictureBox1.ImageLocation = red;
            pictureBox2.ImageLocation = red;
            pictureBox3.ImageLocation = red;
            pictureBox4.ImageLocation = red;
            pictureBox5.ImageLocation = red;
            pictureBox6.ImageLocation = red;
            pictureBox7.ImageLocation = red;
            pictureBox8.ImageLocation = red;
            pictureBox9.ImageLocation = red;
            pictureBox10.ImageLocation = red;
            pictureBox11.ImageLocation = red;
            pictureBox12.ImageLocation = red;
            pictureBox13.ImageLocation = red;
            pictureBox14.ImageLocation = red;
            pictureBox15.ImageLocation = red;
            pictureBox16.ImageLocation = red;
            pictureBox17.ImageLocation = red;
            pictureBox18.ImageLocation = red;
            pictureBox19.ImageLocation = red;
            pictureBox20.ImageLocation = red;
            pictureBox21.ImageLocation = red;
            pictureBox22.ImageLocation = red;
            pictureBox23.ImageLocation = red;
            pictureBox23.ImageLocation = red;
            pictureBox24.ImageLocation = red;
            pictureBox25.ImageLocation = red;
            pictureBox26.ImageLocation = red;
            pictureBox27.ImageLocation = red;
            pictureBox28.ImageLocation = red;
            pictureBox29.ImageLocation = red;
            pictureBox30.ImageLocation = red;
            pictureBox31.ImageLocation = red;
            pictureBox32.ImageLocation = red;
            pictureBox33.ImageLocation = red;
            pictureBox34.ImageLocation = red;
            pictureBox35.ImageLocation = red;
            pictureBox36.ImageLocation = red;
            pictureBox37.ImageLocation = red;
            pictureBox38.ImageLocation = red;
            pictureBox39.ImageLocation = red;
            pictureBox40.ImageLocation = red;

            
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            long ccnum;
            int pin;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε την ώρα προβολής.");
            }
            else if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε τον αριθμό των εισητηρίων\nπου θέλετε να υποβάλλετε σε κράτηση.");
            }
            else if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Παρακαλώ εισάγετε τα στοιχεία πληρωμής!");
            }
            else if (seatsSelected == numericUpDown1.Value )
            {
                    string booker = System.IO.File.ReadAllText("loggedin.txt");
                    if (!String.IsNullOrEmpty(booker))
                    {
                        File.WriteAllText(Application.StartupPath + "/hasres.txt", "yes"); 
                        if (checkBox1.Checked)
                        {
                            MenuView menu = new MenuView();
                            menu.fromWhere = "user";
                            menu.Show();
                        }
                        this.Close();
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            MenuView menu = new MenuView();
                            menu.fromWhere = "guest";
                            menu.Show();
                            this.Close();
                        }
                        else
                        {
                            ConfirmAsVisitor form = new ConfirmAsVisitor();
                            form.Show();
                            this.Close();
                        }
                    }
                
            }            
            else
            {
                MessageBox.Show("Ο αριθμός των εισητηρίων δεν αντιστοιχεί στον αριθμό \nτων κρατήσεων στο πλαίσιο των θέσεων");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            web_interface form = new web_interface();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == green)
            {
                pictureBox1.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox1.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.ImageLocation == green)
            {
                pictureBox4.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox4.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.ImageLocation == green)
            {
                pictureBox3.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox3.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.ImageLocation == green)
            {
                pictureBox2.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox2.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.ImageLocation == green)
            {
                pictureBox5.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox5.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.ImageLocation == green)
            {
                pictureBox10.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox10.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.ImageLocation == green)
            {
                pictureBox7.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox7.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.ImageLocation == green)
            {
                pictureBox8.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox8.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.ImageLocation == green)
            {
                pictureBox9.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox9.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.ImageLocation == green)
            {
                pictureBox6.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox6.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox20.ImageLocation == green)
            {
                pictureBox20.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox20.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (pictureBox17.ImageLocation == green)
            {
                pictureBox17.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox17.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (pictureBox18.ImageLocation == green)
            {
                pictureBox18.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox18.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pictureBox19.ImageLocation == green)
            {
                pictureBox19.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox19.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox16.ImageLocation == green)
            {
                pictureBox16.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox16.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox15.ImageLocation == green)
            {
                pictureBox15.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox15.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.ImageLocation == green)
            {
                pictureBox12.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox12.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.ImageLocation == green)
            {
                pictureBox13.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox13.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox14.ImageLocation == green)
            {
                pictureBox14.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox14.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.ImageLocation == green)
            {
                pictureBox11.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox11.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (pictureBox30.ImageLocation == green)
            {
                pictureBox30.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox30.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (pictureBox27.ImageLocation == green)
            {
                pictureBox27.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox27.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (pictureBox28.ImageLocation == green)
            {
                pictureBox28.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox28.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (pictureBox29.ImageLocation == green)
            {
                pictureBox29.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox29.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (pictureBox26.ImageLocation == green)
            {
                pictureBox26.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox26.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (pictureBox25.ImageLocation == green)
            {
                pictureBox25.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox25.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (pictureBox22.ImageLocation == green)
            {
                pictureBox22.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox22.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (pictureBox23.ImageLocation == green)
            {
                pictureBox23.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox23.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (pictureBox24.ImageLocation == green)
            {
                pictureBox24.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox24.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (pictureBox21.ImageLocation == green)
            {
                pictureBox21.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox21.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            if (pictureBox40.ImageLocation == green)
            {
                pictureBox40.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox40.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            if (pictureBox37.ImageLocation == green)
            {
                pictureBox37.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox37.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            if (pictureBox38.ImageLocation == green)
            {
                pictureBox38.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox38.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            if (pictureBox39.ImageLocation == green)
            {
                pictureBox39.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox39.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            if (pictureBox36.ImageLocation == green)
            {
                pictureBox36.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox36.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            if (pictureBox35.ImageLocation == green)
            {
                pictureBox35.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox35.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (pictureBox32.ImageLocation == green)
            {
                pictureBox32.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox32.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            if (pictureBox33.ImageLocation == green)
            {
                pictureBox33.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox33.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            if (pictureBox34.ImageLocation == green)
            {
                pictureBox34.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox34.ImageLocation = green;
                seatsSelected++;
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (pictureBox31.ImageLocation == green)
            {
                pictureBox31.ImageLocation = red;
                seatsSelected--;
            }
            else
            {
                pictureBox31.ImageLocation = green;
                seatsSelected++;
            }
        }
    }
}
