using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace FinalAAY
{
    public partial class MovieNight : Form
    {
        
        public MovieNight()
        {
            InitializeComponent();
            timer1.Start();
            Bar enough = new Bar();
            enough.thatsenough = 0;
        }

        private void MovieNight_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Customer form = new Customer();
            form.Show();
            this.Close();
        }
    }
}
