using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetDLab1
{
    public partial class frmUnitsShipped : Form
    {
        // Declaring Variables
        
        // This variable holds our counter
        int counter = 1;
        // This variable stores our user input
        int allValidInputs = 0;
        // This constant is the maximum number of days of units shipped to be entered
        const int MAX_DAYS = 7;
        // This constant holds the maximum amount of units shipped allowed per day
        const int MAX_VALUE = 5000;
        // This constant holds the minimum amounts of units shipped allowed per day
        const int MIN_VALUE = 0;
       
       

        public frmUnitsShipped()
        {
            InitializeComponent();
            // This changes the day number using our counter
            lblDays.Text = "Days: " + counter; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // This variable holds our user input
            int validInput = 0;

            // Checking to see if the user input is a whole number
            if (Int32.TryParse(txtUserEntry.Text, out validInput))
            {
                //Checking to see if the user input is within range
                if (validInput <= MAX_VALUE && validInput >= MIN_VALUE)
                {
                    // Clears any errors that were displayed for the last user input
                    lblResults.Text = "";
                    // Adds one to our counter for every valid input the user makes
                    counter++;

                    // Stores the validated user input in our accumulator
                    allValidInputs += validInput;
                    // Writes the valid input into our multiline textbox where user input is displayed
                    txtUserData.Text += validInput + Environment.NewLine;
                    
                    //Once counter reaches its limit the statements below execute
                    if (counter > MAX_DAYS)
                    {
                        // Calculates the average of the user input and displays it in the results label
                        lblResults.Text = "Average per day: " + Math.Round((double) allValidInputs / MAX_DAYS, 2);
                        // Disables the user of the Enter button
                        btnEnter.Enabled = false;
                        // Disables the use of the user input textbox
                        txtUserEntry.ReadOnly = true;
                        
                    }
                    else
                    {
                        // If the maximum days has not been reached we add 1 to the counter and itterate
                        lblDays.Text = "Days: " + counter;

                    }
                }
                else
                {   
                    // This error is displayed if the user input is not within range
                    lblResults.Text = "ERROR: the user entry is not in the valid range of 0 to 5000.";
                    txtUserEntry.Focus();
                }
            }
            else
            {   
                // This error is displayed if the user input is not a whole number
                lblResults.Text = "ERROR: the user entry is not a whole number. Please try again.";
                txtUserEntry.Focus();
            }

            // Clears the user input textbox and resets the focus on itself for the next entry
            txtUserEntry.Clear();
            txtUserEntry.Focus();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Resets Counter
            counter = 1;
            // Resets Days
            lblDays.Text = "Days: " + counter;
            // Clears the User Entry text box
            txtUserEntry.Clear();
            // Clears the User Data text box
            txtUserData.Clear();
            // Resets/Clears the message label box
            lblResults.Text = "";
            // Set focus to User entry box
            txtUserEntry.Focus();
            // Resets ReadOnly on txtUserEntry
            txtUserEntry.ReadOnly = false;
            // Enables Enter button
            btnEnter.Enabled = true;

         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

      
    }
}
