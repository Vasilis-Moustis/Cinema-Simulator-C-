using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAAY
{
    public partial class Cleaning : Form
    {

        List<Button> ButtonList = new List<Button>();

        private Random r = new Random();

        int count = 1;

        int N = 40;

        int x = 10;
        int y = 80;

        int decision;

        public Cleaning()
        {
            InitializeComponent();
        }

        private void Cleaning_Load(object sender, EventArgs e)
        {
            File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToLongDateString());
            File.AppendAllText(Application.StartupPath + "/logs.txt", "\n");

            ButtonList = new List<Button>();
            for (int i = 0; i < N; i++)
            {
                Button b = new Button();
                ButtonList.Add(b);
            }

            foreach (Button b in ButtonList)
            {
                if (x < this.Width - b.Width)
                {
                    b.Location = new Point(x, y);
                    b.Width = 40;
                    b.Height = 40;
                    b.BackColor = Color.Green;
                    b.Text = count.ToString();
                    this.Controls.Add(b);
                    x += b.Width + 40;
                    count++;
                }
                else
                {
                    x = 10;
                    y += b.Height + 40;
                    b.Location = new Point(x, y);
                    b.Width = 40;
                    b.Height = 40;
                    b.BackColor = Color.Green;
                    b.Text = count.ToString();
                    this.Controls.Add(b);
                    x += b.Width + 40;
                    count++;
                }
            }

            count = 0;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 40)
            {
                ButtonList.ElementAt(count).BackColor = Color.Red;
                count++;
                decision = r.Next(10);
                if (decision < 7)
                {
                    File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tRobot cleaner successfully cleaned seat " + count.ToString() + "\n");
                }
                else if (decision == 7)
                {
                    File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tRobot cleaner cleaned seat " + count.ToString() + " but it was quite a mess to deal with...\n");
                }
                else if (decision == 8)
                {
                    File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tRobot cleaner cleaned seat " + count.ToString() + " and also some forgoten stuff from the viewer seating there...\n");
                }
                else
                {
                    File.AppendAllText(Application.StartupPath + "/logs.txt", DateTime.Today.ToString() + "\tRobot cleaner cleaned seat " + count.ToString() + " but cinema equipment was found damaged...\n");
                }
            }
            else
            {
                timer1.Stop();
                File.AppendAllText(Application.StartupPath + "/logs.txt", "\n\n\n\n");
                this.Close();
            }
        }
    }
}
//File.WriteAllText(Application.StartupPath + "/logs.txt", "Bright");