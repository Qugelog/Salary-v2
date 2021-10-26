using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary.Forms
{
    public partial class PreloaderForm : Form
    {
        public PreloaderForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;

            if(panel3.Width >= panel2.Width)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Hide();
                new LoginForm().ShowDialog();

            }
        }
    }
}
