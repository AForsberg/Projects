//By Anton Forsberg
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {

        //Default values
        private const int totalSeats = 240;
        private int reservedSeats = 0;

        //Input variables
        private double price = 0.0;
        private string customerName = string.Empty;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            //Initialize method
            InitializeGUI();
        }

        /// <summary>
        /// Clears input and outputs
        /// Initializes stuff (selects the reserve radiobutton, fills the seatlist)
        /// </summary>
        /// <remarks>Called from constructor</remarks>
        private void InitializeGUI()
        {
            //Reserve-button checked as default
            rbtnReserve.Checked = true;

            //Clear seatslist and fill with vacant seats
            lstSeats.Items.Clear();
            for (int i = 0; i < totalSeats; i++)
            {
                string strOut = string.Format("{0,5} {1,-8} {2, -18} {3, 10:f2}", i + 1, "  Vacant", customerName, price);
                lstSeats.Items.Add(strOut);
            }
            //clear input controls
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;

            //clear output controls
            lblVacSeats.Text = string.Empty;
            lblRsrvSeats.Text = string.Empty;
            lblTotSeats.Text = totalSeats.ToString();

        }

        /// <summary>
        /// Reads the users inputs and checks that they are valid
        /// </summary>
        /// <returns>true if both name and price returns true</returns>
        private bool ReadAndValidateInput()
        {
            //validates name, nameOK is set to true if name is not empty/null
            bool nameOK = ReadAndValidateName();

            //validates price, priceOK is set to true if it is a positive double value
            bool priceOK = ReadAndValidatePrice();

            return nameOK && priceOK;
        }
        /// <summary>
        /// Takes the user-inputed price and converts to a double if it is valid and positive
        /// </summary>
        /// <returns>true if price is valid and > 0</returns>
        private bool ReadAndValidatePrice()
        {
            string input = txtPrice.Text;

            if (InputUtility.GetPositiveDouble(input, out price))
            {
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Validates that name is valid (not empty or only spaces)
        /// </summary>
        /// <returns>true if name is valid</returns>
        private bool ReadAndValidateName()
        {
           customerName = txtName.Text;

           if (!InputUtility.ValidateString(customerName))
           {
               MessageBox.Show("Invalid entry. Name cannot be empty," + Environment.NewLine + " and must have at least one character (cannot be a blankspace)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtName.Focus();
               txtName.Text = " ";
               txtName.SelectAll();
               return false;
           }
           else
               return true;
        }
        /// <summary>
        /// Updates the GUI with new data given by user input
        /// </summary>
        /// <remarks>called when btnOK is pressed</remarks>
        private void UpdateGUI()
        {
            int index = lstSeats.SelectedIndex;
            //shows message if no item is selected
            if (index < 0)
            {
                MessageBox.Show("Please select an item in the list!");
                return;
            }

            string strOut = string.Empty;
            string strReserved = "Vacant";

            //Checks whether input is a reservation or cancelation
            if (rbtnReserve.Checked)
                strReserved = "Reserved";

            else
            {
                customerName = string.Empty;
                price = 0.0;
            }

            //updates seatlist with new data
            strOut = string.Format("{0,5} {1,-8} {2,-18} {3,10:f2}", index + 1, strReserved, customerName, price);
            lstSeats.Items.RemoveAt(index);
            lstSeats.Items.Insert(index, strOut);

            //Updates labels with new values
            lblRsrvSeats.Text = reservedSeats.ToString();
            lblVacSeats.Text = (totalSeats - reservedSeats).ToString();
            lblTotSeats.Text = totalSeats.ToString();
        }
        /// <summary>
        /// Method for when btnOK is clicked. Checks if the inputs are valid and if they are 
        /// checks if reservation/cancelation and updates reserved seats accordingliy.
        /// Calls for UpdateGUI to display updated results
        /// </summary>
        /// <param name="sender">Reference to object that fired the event, ie the button</param>
        /// <param name="e">event info</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool inputOK = ReadAndValidateInput();

            if (inputOK)
            {
                if (rbtnReserve.Checked)
                    reservedSeats++;
                else
                    reservedSeats--;
                UpdateGUI();
            }

        }
        /// <summary>
        /// Enables the textboxes if the reserve radiobutton is checked.
        /// </summary>
        /// <param name="sender">Reserve radiobutton</param>
        /// <param name="e">event info</param>
        private void rbtnReserve_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
        }
        /// <summary>
        /// Disables textboxes if cancel radiobutton is checked.
        /// </summary>
        /// <param name="sender">Cancel radiobutton</param>
        /// <param name="e">event info</param>
        private void rbtnCancel_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
        }

       
    }
}
