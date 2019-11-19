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
    public partial class Form2 : Form
    {

        int  nWidth, mHeight, bAmt; // Holding w, h, and * data

        public Form2(int nElements, int mElements, int bElements)
        {
            // Setting width and height and b for rest of class
            nWidth  = nElements;
            mHeight = mElements;
            bAmt    = bElements;

            InitializeComponent(nWidth, mHeight, bAmt);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}