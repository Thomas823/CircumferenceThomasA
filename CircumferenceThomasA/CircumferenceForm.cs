/*
 * Created by: Thomas Aubin
 * Created on: 6 Apri;, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference
 * This program calculates the circumference of a circle for a given radius, r
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumferenceThomasA
{
    public partial class frmCircumference : Form
    {
        // Declare variables
        const double PI = 3.14;
        double usersInput;
        double answer;

        public frmCircumference()
        {
            InitializeComponent();

            // Hide answer prompt
            lblCircumferenePrompt.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get users radius
            usersInput = Convert.ToDouble(txtRadius.Text);

            // Calculate answer
            answer = 2 * PI * usersInput;

            // Display answer prompt and answer
            lblCircumferenePrompt.Show();
            lblCircumferenceAnswer.Text = Convert.ToString(answer) + " cm";
        }
    }
}