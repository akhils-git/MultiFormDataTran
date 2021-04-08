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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblLight.BackColor = Color.Red;
            File.WriteAllText("C:/settings.txt", lblLight.BackColor.ToArgb().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblLight.BackColor = Color.Green;
            File.WriteAllText("C:/settings.txt", lblLight.BackColor.ToArgb().ToString());
        }
    }
}
