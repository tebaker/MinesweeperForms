using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    struct btn
    {
        public Button heldBtn;
        public string btnText;     // What element the button is HOLDING (possibly hidden from the player)
        public string displayText; // What text the button is DISPLAYING (what the player gets to see)
        public int    btnTabIndex; // The button's single dimentional array index
        public int    btnN;        // The button's n coord
        public int    btnM;        // The button's m coord
        public bool   uncovered;   // Only true when the button has been completely uncovered all its neighbors
                                   // (when btn text is null and clicked on by user or next to a null btn clicked on by user).

        public btn(Button hldBtn, string btnTxt, string dspTxt, int btnTab, int n, int m)
        {
            heldBtn = hldBtn;
            btnText = btnTxt;
            displayText = dspTxt;
            btnTabIndex = btnTab;
            btnN = n;
            btnM = m;
            uncovered = false;
        }
    } // End - struct

    // Delegate test
    public delegate void clickCall(object sender, EventArgs e);

    partial class Form2
    {
        // Size of the clickable sweeper buttons in px
        const int BTN_SIZE = 25;

        // Multidimentional array for holding n x m amount of buttons for new sweeper
        // n x m passed in from InitializeComponent function
        btn[,] btnArray;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int nElements, int mElements, int bElements)
        {
            // Creating multidimentional button array
            btnArray = new btn[nElements, mElements];

            this.SuspendLayout();
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            // Client Size = number of n x m elements * 25 (where 25 is w, h dimentions in px)
            this.ClientSize = new System.Drawing.Size(nElements * BTN_SIZE, mElements * BTN_SIZE);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

            // Creating grid of buttons that the user can interact with
            for (int i = 0; i < nElements; i++)
            {
                for (int j = 0; j < mElements; j++)
                {
                    // Creating new Button for user to click
                    Button newBtn = new Button();

                    newBtn.Size = new System.Drawing.Size(BTN_SIZE, BTN_SIZE);
                    newBtn.Location = new System.Drawing.Point(i * BTN_SIZE, j * BTN_SIZE);
                    newBtn.Text = null;
                    newBtn.TabIndex = i + j * nElements;
                    this.Controls.Add(newBtn);

                    // Creating new btn struct to hold button information
                    btn newBtnContainer = new btn(newBtn, null, null, newBtn.TabIndex, i, j);

                    // Event Handler using an Anonymouse Delegate to pass extra data to a click function
                    newBtn.Click += new System.EventHandler((object sender, EventArgs e)=>btnClick(sender, e, newBtn));

                    btnArray[i,j] = newBtnContainer;
                }
            }

            // Generating board and assigning text once all buttons are placed
            generateBoard(nElements, mElements, bElements);

        } // END - InitializeComponent

        /* A delegate function that will handle button click event.
           The following checks will be made:
               1) Is button null?
                      If so, see function.
               2) Is button '*'?
                      If so, player loses. Game over, exit game.
               3) Is button a numbered element?
                      If so, uncover number - nothing more.
         */
        private void btnClick(object sender, EventArgs e, Button btn)
        {
            //MessageBox.Show("TabIndex: " + (btn.TabIndex).ToString());
        }


        private void generateBoard(int nElements, int mElements, int bElements)
        {
            // Generaring random index for b placement
            Random rand = new Random();

            int bPlaced = 0; // will remain false until all b legally placed

            int[] bPlacedArray = new int[bElements];

            // Randomly placing bombs on the board
            while(bPlaced < bElements)
            {
                try
                {
                    // Generating random index bwteen 0 and n exclusive, and 0 and m exclusive
                    int nIndex = rand.Next(nElements);
                    int mIndex = rand.Next(mElements);

                    // If btn text does not == *, meaning if it's not a *, then assign it to be a *.
                    if(btnArray[nIndex,mIndex].btnText != "*")
                    {
                        btnArray[nIndex, mIndex].btnText = "*";
                        btnArray[nIndex, mIndex].displayText = "*";
                        // Updating display test to match held display text
                        btnArray[nIndex, mIndex].heldBtn.Text = "*";

                        // Updating numbers around b
                        updateNumbers(nIndex, mIndex);

                        // Incrementing b placed amount
                        bPlaced++;
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }// end - generateBoard

        // Checking the 8 squares around b, updating number if valid to do so
        public void updateNumbers(int nIndex, int mIndex)
        {
            // Holding the indecies to be checked in the 8 spaces around the b
            int checkIndexN = nIndex;
            int checkIndexM = mIndex;

            // N  check (-n, m)
            checkIndexN = nIndex - 1;
            checkIndexM = mIndex;
            // Going up; checking if n is in bounds
            if (checkIndexN >= 0)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
            // NE check (-n,+m)
            checkIndexN = nIndex - 1;
            checkIndexM = mIndex + 1;
            // Going up, going right; checking if n, m is in bounds
            if (checkIndexN >= 0 && checkIndexM < mHeight)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
            // E  check (n, +m)
            checkIndexN = nIndex;
            checkIndexM = mIndex + 1;
            // Going right; checking if m is in bounds
            if (checkIndexM < mHeight)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
            // SW check (+n,+m)
            checkIndexN = nIndex + 1;
            checkIndexM = mIndex + 1;
            // Going down, going right; checking if n, m is in bounds
            if (checkIndexN < nWidth && checkIndexM < mHeight)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
            // S  check (+n, m)
            checkIndexN = nIndex + 1;
            checkIndexM = mIndex;
            // Going down; checking if n is in bounds
            if (checkIndexN < nWidth)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
            // SW check (+n,-m)
            checkIndexN = nIndex + 1;
            checkIndexM = mIndex - 1;
            // Going down, going left; checking if n, m is in bounds
            if (checkIndexN < nWidth && checkIndexM >= 0)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
            // W  check (n, -m)
            checkIndexN = nIndex;
            checkIndexM = mIndex - 1;
            // Going left; checking if m is in bounds
            if (checkIndexM >= 0)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
            // NW check (-n,-m)
            checkIndexN = nIndex - 1;
            checkIndexM = mIndex - 1;
            // Going left; checking if m is in bounds
            if (checkIndexN >= 0 && checkIndexM >= 0)
            {
                //MessageBox.Show("n: " + checkIndexN + " m: " + checkIndexM);
                incrementValues(checkIndexN, checkIndexM);
            }
        }// End - updateNumbers

        // Checking the 8 values around the *. If another *, do nothing; if null, assign "1"; if a number, incr by 1; if NAN and not null, error.
        public void incrementValues(int checkIndexN, int checkIndexM)
        {
            // Checking if element is not equal to a b
            if (btnArray[checkIndexN, checkIndexM].btnText != "*")
            {
                // If text is null, assigning string to 1
                if (btnArray[checkIndexN, checkIndexM].btnText == null)
                {
                    btnArray[checkIndexN, checkIndexM].btnText = "1";
                    btnArray[checkIndexN, checkIndexM].heldBtn.Text = "1";
                }
                // If number is > 0 - basically, if it's a number - assign it to 1 plus that number (up to 8 theorotically)
                else if (Int32.Parse(btnArray[checkIndexN, checkIndexM].btnText) >= 0)
                {
                    btnArray[checkIndexN, checkIndexM].btnText = (Int32.Parse(btnArray[checkIndexN, checkIndexM].btnText) + 1).ToString();
                    btnArray[checkIndexN, checkIndexM].heldBtn.Text = btnArray[checkIndexN, checkIndexM].btnText;
                }
                else
                {
                    MessageBox.Show("Inside incrementValues(): Box not null but not a number. Other error");
                }
            }
        }// End - incrementValues
        #endregion
    }
}