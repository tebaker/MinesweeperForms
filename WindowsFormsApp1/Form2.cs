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
        bool generatingAsts, generatingNums, hidingData; // Check boxes for displaying different amounts of data

        public Form2(int nElements, int mElements, int bElements, bool generateAsts, bool generateNums, bool hideData)
        {
            // Setting width and height and b for rest of class
            nWidth  = nElements;
            mHeight = mElements;
            bAmt    = bElements;

            generatingAsts = generateAsts;
            generatingNums = generateNums;
            hidingData     = hideData;

            InitializeComponent(nWidth, mHeight, bAmt);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}