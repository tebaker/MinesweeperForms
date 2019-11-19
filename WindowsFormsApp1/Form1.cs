using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void nxmResult_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            // Updating n x m result for the user
            nxmResult.Text = (numericUpDownN.Value * numericUpDownM.Value).ToString();

            // Changing max bomb value based on n x m
            numericUpDownB.Maximum = numericUpDownN.Value * numericUpDownM.Value;
        }

        private void numericUpDownM_ValueChanged(object sender, EventArgs e)
        {
            // Updating n x m result for the user
            nxmResult.Text = (numericUpDownN.Value * numericUpDownM.Value).ToString();

            // Changing max bomb value based on n x m
            numericUpDownB.Maximum = numericUpDownN.Value * numericUpDownM.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // Creating new instance of Form2 that will display the sweeper
            Form2 form2 = new Form2((int)numericUpDownN.Value, (int)numericUpDownM.Value, (int)numericUpDownB.Value);

            // Displaying Form2
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating new instance of Form2 that will display the sweeper
            Form2 form2 = new Form2(15, 15, 15);

            // Displaying Form2
            form2.ShowDialog();
        }
    }
}
