using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesla_Programming_Challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_BTN_Click(object sender, EventArgs e)
        {
            //we create the model Y object
            Model_Y model_Y = new Model_Y();

            //we let the user know we have created the model Y
            MessageBox.Show("Model Y has been created!");
        }
    }
}
