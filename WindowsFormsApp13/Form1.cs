using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

                int n = int.Parse(textBox1.Text);
               


                double s = 6* n*n;
            double v = n * n * n;
                

                 label1.Text = ($"Площадь  {s} ");
            label2.Text = ($"Объём  {v} ");


        }
    }
}
