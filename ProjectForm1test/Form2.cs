using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm1test
{
    public partial class Form2 : Form
    {
        public Form2(string[] Aform)
        {
            InitializeComponent();
            label7.Text = Aform[0];
            label8.Text = Aform[1];
            label9.Text = Aform[2];
            label10.Text = Aform[3];
            label11.Text = Aform[4];
            label12.Text = Aform[5];
             

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
