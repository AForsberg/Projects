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

namespace Assignment4
{
    public partial class MainForm : Form
    {

        //Default values
        private const int m_numOfSeats = 240;

        private SeatManager m_seatManager;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Create new instance of seatmanager
            m_seatManager = new SeatManager(m_numOfSeats);
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

            //Clear seatslist
            lstSeats.Items.Clear();

            //clear input controls
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;

            //clear output controls
            lblVacSeats.Text = string.Empty;
            lblRsrvSeats.Text = string.Empty;
            lblTotSeats.Text = m_numOfSeats.ToString();

            UpdateGUI();

        }


        /// <summary>
        /// Updates the GUI with new data given by user input
        /// </summary>
        /// <remarks>called when btnOK is pressed</remarks>
        private void UpdateGUI()
        {
            int index = lstSeats.SelectedIndex;

            //Checks whether input is a reservation or cancelation
            lstSeats.Items.Clear();

            for (int i = m_numOfSeats - 1; i >= 0; i--)
            {

                lstSeats.Items.Insert(0, m_seatManager.GetSeatInfoAt(i));
            }



            //Updates labels with new values
            lblRsrvSeats.Text = Convert.ToString(m_seatManager.GetNumReserved());
            lblVacSeats.Text = Convert.ToString(m_seatManager.GetNumVacant());
            lblTotSeats.Text = Convert.ToString(m_numOfSeats);
        }
        /// <summary>
        /// Checks that the user has selected an item in the seatlist
        /// </summary>
        /// <returns></returns>
        private bool CheckSelectedIndex()
        {
            if (lstSeats.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item in the list", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Reads the users inputs and checks that they are valid
        /// </summary>
        /// <returns>true if both name and price returns true</returns>
        private bool ReadAndValidateInput(out string name, out double price)
        {
            //validates name, nameOK is set to true if name is not empty/null
            bool nameOK = ReadAndValidateName(out name);

            //validates price, priceOK is set to true if it is a positive double value
            bool priceOK = ReadAndValidatePrice(out price);

            return nameOK && priceOK;
        }
        /// <summary>
        /// Takes the user-inputed price and converts to a double if it is valid and positive
        /// </summary>
        /// <returns>true if price is valid and > 0</returns>
        private bool ReadAndValidatePrice(out double price)
        {
            string input = txtPrice.Text;

            if (InputUtility.GetPositiveDouble(input, out price))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid price. Must be positive and consisting of at least one number, whole or decimal.", "Invalid price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Validates that name is valid (not empty or only spaces)
        /// </summary>
        /// <returns>true if name is valid</returns>
        private bool ReadAndValidateName(out string name)
        {
            name = txtName.Text;

            if (!InputUtility.ValidateString(name))
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
        /// Called when users clicks OK. Checks if a seat is selected in list.
        /// Calls method ReserveOrCancelSeat
        /// </summary>
        /// <param name="sender">Reference to object that fired the event, ie the button</param>
        /// <param name="e">event info</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedIndex())
                return;

            ReserveOrCancelSeat();

        }
        /// <summary>
        /// Reserves or cancels a seat, depending on user choice
        /// </summary>
        private void ReserveOrCancelSeat()
        {
            string name = "";
            double price = 0.0;

            if (rbtnReserve.Checked)
            {
                if (!ReadAndValidateInput(out name, out price))
                {
                    return;
                }
                if (m_seatManager.ReserveSeat(name, price, lstSeats.SelectedIndex))
                {
                    m_seatManager.ReserveSeat(name, price, lstSeats.SelectedIndex);
                }
                else
                {
                    if (MessageBox.Show("This seat is already reserved! Do you want to proceed anyways?", "Seat already reserved", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        m_seatManager.CancelSeat(lstSeats.SelectedIndex);
                        m_seatManager.ReserveSeat(name, price, lstSeats.SelectedIndex);
                    }
                }
            }
            else
            {
                if (m_seatManager.CancelSeat(lstSeats.SelectedIndex))
                    m_seatManager.CancelSeat(lstSeats.SelectedIndex);
                else
                    MessageBox.Show("Seat is already vacant", "Seat already vacant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateGUI();
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
