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
    public partial class ManualCleaner : Form
    {
        public ManualCleaner()
        {
            InitializeComponent();
        }
        int decision;
        Random r = new Random();
        int count = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            CleanerControl form = new CleanerControl();
            form.Show();
            this.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.Green;
            decision = r.Next(10);
            if (decision < 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner successfully cleaned seat " + count.ToString() + "\n");
            }
            else if (decision == 7)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
            }
            else if (decision == 8)
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " and also some forgotten stuff from the viewer seating there...\n");
            }
            else
            {
                File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tcleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
            }
            count++;

        }

        private void ManualCleaner_Load(object sender, EventArgs e)
        {
         

        }
    }
}
