// Programmer:  Mahesh
// Student #:   200330980
// Date:        Feburary 12,2017
// Course:      COMP 1004
// Program:     Assignment 2
// Title:       Sharp Auto Center
// Description: This program calculates the amount due on a New or Used Vehicle after adding the additional items costs and various functionality
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class SharpAuoForm : Form
    {
        /// <summary>
        /// default constructor`
        /// </summary>
        public SharpAuoForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handler for the TextChanged event on the BasePrice, OptionBox and AllowanceBox controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _PriceBox_TextChanged(object sender, EventArgs e)
        {
            // Cast the sender to a TextBox
            TextBox textSender = (TextBox)sender;
            // Give sender contents proper formatting
            textSender.Text = _FormatCurrency(textSender.Text);
            // Move cursor to end of content
            textSender.Select(textSender.Text.Length, 0);
        }

        /// <summary>
        /// Handler for the Click event on the CalculateButton and calculateToolStripMenuItem controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _CalculateButton_Click(object sender, EventArgs e)
        {
            // local instance variables
            double _baseAmount;
            double _options;
            double _allowance;
            double _subtotal;
            double _tax;
            double _total;
            double _due;

            // cast textbox contents into appropriate variables for calculations
            try
            {
                _baseAmount = Convert.ToDouble(_SanitizeNumeric(basePriceBox.Text));
            }
            catch
            {
                _baseAmount = 0;
            }
            try
            {
                _options = Convert.ToDouble(_SanitizeNumeric(optionsBox.Text));
            }
            catch
            {
                _options = 0;
            }

            try
            {
                _allowance = Convert.ToDouble(_SanitizeNumeric(allowanceBox.Text));
            }
            catch
            {
                _allowance = 0;
            }

            // do the basic calculations
            _subtotal = _options + _baseAmount;
            _tax = _calculateTax(_subtotal);
            _total = _subtotal + _tax;
            _due = _total - _allowance;

            // output results
            subTotalBox.Text = _FormatCurrency(Convert.ToString(_subtotal));
            taxBox.Text = _FormatCurrency(Convert.ToString(_tax));
            totalBox.Text = _FormatCurrency(Convert.ToString(_total));
            amountDueBox.Text = _FormatCurrency(Convert.ToString(_due));
        }

        /// <summary>
        /// the clear button clears the text field of different labels 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ClearButton_Click(object sender, EventArgs e)
        {
            // set all textboxes to default value
            basePriceBox.Text = "";
            optionsBox.Text = "";
            subTotalBox.Text = "";
            taxBox.Text = "";
            totalBox.Text = "";
            allowanceBox.Text = "$0";
            amountDueBox.Text = "";

            //set all checkbox/radiobuttons to defaults
            leatherCheckBox.Checked = false;
            stereoCheckBox.Checked = false;
            nosCheckBox.Checked = false;
            computerCheckBox.Checked = false;
            standardRadioButton.Checked = true;
        }

        /// <summary>
        /// exitbutton_click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// checkedChangedHandler for initializing the price of the 
        /// additional items and the exterior finish
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _CheckedChangedHandler(object sender, EventArgs e)
        {
            // Local variable
            Double optionsTotal = 0;
            // Local constants for accessory prices
            const double _stereoSystem = 425.76;
            const double _leatherInterior = 987.41;
            const double _computerNavigation = 1741.23;
            const double _nos = 950.25;
            const double _customizedDetailing = 599.99;
            const double _pearlized = 345.72;
            const double _matted = 550.25;

            // For every accessory that is checked, add it's price to the optionsTotal
            if (stereoCheckBox.Checked)
            {
                optionsTotal += _stereoSystem;
            }
            if (leatherCheckBox.Checked)
            {
                optionsTotal += _leatherInterior;
            }
            if (computerCheckBox.Checked)
            {
                optionsTotal += _computerNavigation;
            }
            if (nosCheckBox.Checked)
            {
                optionsTotal += _nos;
            }
            if (detailingRadioButton.Checked)
            {
                optionsTotal += _customizedDetailing;
            }
            if (pearlizedRadioButton.Checked)
            {
                optionsTotal += _pearlized;
            }
            if (mattedRadioButton.Checked)
            {
                optionsTotal += _matted;
            }
            // display the total options amount in the appropriate TextBox
            optionsBox.Text = _FormatCurrency(optionsTotal.ToString());
        }

        // helper button for calculating the tax
        private double _calculateTax(double subtotal)
        {
            return subtotal * 0.13;
        }


        private void _fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show dialog
            fontDialog.ShowDialog();
            basePriceBox.Font = fontDialog.Font;
            amountDueBox.Font = fontDialog.Font;
        }

        private void _colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows the dialog box for changing the color of he below text fields
            colorDialog.ShowDialog();

            basePriceBox.BackColor = colorDialog.Color;

            amountDueBox.BackColor = colorDialog.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("This program calculates the amount due on a New or Used Vehicle", "About", MessageBoxButtons.OK);
            //create a new form
            AboutForm aboutForm = new AboutForm();

            // show the about form with showdialog(a modal method to display the form)
            aboutForm.ShowDialog();
        }

        
        // _FormatCurrency takes an input string and formats it according 
        // to standard currency format (e.g. $4,536.74), then returns the
        // formatted string value.
        // Should be refactored
        private string _FormatCurrency(string textValue)
        {
            if (textValue == "")
            {
                return "";
            }

            // Strip all non-numeric characters from the string
            textValue = _SanitizeNumeric(textValue);

            // Split the string into two parts, for dollars and cents
            string[] parts = textValue.Split('.');
            // Store the cents for later or a sentinel value if no cents exist
            string cents = (parts.Length > 1) ? parts[1] : "noCents";

            // Store the dollar portion of the string in a character array
            char[] dollars = parts[0].ToCharArray();
            // Create a character list to store the formatted string
            List<char> formattedCharacterList = new List<char>();

            // Index variable to track progress through loop
            int index = 1;
            // Loop through the character array in reverse order
            foreach (char n in dollars.Reverse())
            {
                // Add a character to the list
                formattedCharacterList.Add(n);
                if (index % 3 == 0 && index != dollars.Length)
                {
                    // Insert a comma after every third character unless
                    // we've reached the end of the array
                    formattedCharacterList.Add(',');
                }

                // Increment the index variable
                index++;
            }

            // Put the character list back in order
            formattedCharacterList.Reverse();

            // Convert the character list to a string
            string formattedCurrency = new string(formattedCharacterList.ToArray());

            formattedCurrency = "$" + formattedCurrency;
            if (cents != "noCents")
            {
                // If there are cents to add...
                if (cents.Length == 1 && this.ActiveControl != basePriceBox && this.ActiveControl != allowanceBox)
                {
                    // If there's no trailing zero and focus left, add one
                    cents = cents + "0";
                }
                // ... add the cents
                formattedCurrency = formattedCurrency + "." + cents;
            }

            // Return the nicely formatted string
            return formattedCurrency;
        }

        // _SanitizeNumeric takes an input string and strips out all 
        // non-numeric characters while ensuring there are no more
        // than two decimal places in the resulting number.  It then
        // returns this number as a string.
        private string _SanitizeNumeric(string textValue)
        {
            int radixPosition = -1;
            int index = 0;
            bool validNumber = false;
            bool foundNonZero = false;

            // put string in char array and create list to store clean string
            char[] characters = textValue.ToCharArray();
            List<char> CleanedCharacterList = new List<char>();

            // iterate through char array
            foreach (char c in characters)
            {
                validNumber = true;
                try
                {
                    // Attempt conversion of character to number
                    Convert.ToInt16(c.ToString());
                    // checking for non-zero characters so that leading zeros can be dropped
                    if (c != '0')
                    {
                        foundNonZero = true;
                    }
                }
                catch
                {
                    // if it fails, not a valid number
                    validNumber = false;
                }

                // if it's a valid number and no decimal point as been found
                // or if it's a valid number and there are two or fewer characters after the decimal
                // or if it's the first decimal point found
                if (validNumber && (c != '0' || c == '0' && foundNonZero) && (radixPosition < 0 || index < radixPosition + 3) || (c == '.' && radixPosition < 0))
                {
                    // add the character to the list
                    CleanedCharacterList.Add(c);
                }

                if (c == '.' && radixPosition < 0)
                {
                    // update radixPosition of this is the first time one is found
                    radixPosition = index;
                }

                index++;
            }

            // return the cleaned string
            return new string(CleanedCharacterList.ToArray());
        }

    }
}
