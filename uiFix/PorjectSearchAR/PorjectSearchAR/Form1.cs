using PorjectSearchAR.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorjectSearchAR
{
    public partial class Main : Form
    {

        NavigationControl navigationControl;
       
        public Main()
        {
            InitializeComponent();
            InitializeNavigationControl();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OziExpererApp_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            { new main(), new data(), new eitMain()};

            navigationControl = new NavigationControl(userControls, panel2); // create an instance of NavigationControl class
            navigationControl.Display(0); // display UserControl1 as default
        }

        


    }
}
