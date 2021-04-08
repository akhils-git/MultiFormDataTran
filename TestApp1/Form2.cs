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

namespace TestApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLight.BackColor = Color.FromArgb(Convert.ToInt32(File.ReadAllText("C:/settings.txt")));
        }
    }
}
