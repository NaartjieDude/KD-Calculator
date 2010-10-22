using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kill_to_Death_Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Initialise variables
            int kill;
            int death;
            float ratio;
            //Convert data from text boxes to integers
            kill = Convert.ToInt32(killsBox.Text);
            death = Convert.ToInt32(deathsBox.Text);
            //Ratio stuff
            ratio = (float)kill / death; // Assign as float to enable floating point arithmetic then divide 
            ratio = (float)Math.Round(ratio, 2); // Returns double so assign to float and round off
            ratioLabel.Text = ratio.ToString(); //Display text from ratio in ratioLabel as a string
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            //About button
            MessageBox.Show("Read the Read Me, as I don't feel like typing it all out in a message box", "About");
        }

    }
}
