using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class SeatManager
    {
        //number of seats
        private readonly int m_totNumOfSeats;
        //array containing customernames
        private string[] m_nameList = null;
        //array containing prices
        private double[] m_priceList = null;

        /// <summary>
        /// Constructor, initializations are done
        /// </summary>
        /// <param name="maxNumOfSeats">number of seats</param>
        public SeatManager(int maxNumOfSeats)
        {
            //m_totnumofseats is assigned a value
            m_totNumOfSeats = maxNumOfSeats;
            m_nameList = new string[m_totNumOfSeats];
            m_priceList = new double[m_totNumOfSeats];
        }
        /// <summary>
        /// Checks is index is within valid range
        /// </summary>
        /// <param name="index">index to be checked</param>
        /// <returns>true if valid, false otherwise</returns>
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < m_totNumOfSeats)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Calculates number of reserved seats
        /// </summary>
        /// <returns>number of reserved seats</returns>
        public int GetNumReserved()
        {
            int numReserved = 0;
            for (int index = 0; index < m_totNumOfSeats; index++)
            {
                if (!String.IsNullOrEmpty(m_nameList[index]))
                    numReserved++;
            }
            return numReserved;
        }

        /// <summary>
        /// Calculates number of vacant seats
        /// </summary>
        /// <returns>number of vacant seats</returns>
        public int GetNumVacant()
        {
            int numVacant = 0;
            for (int index = 0; index < m_totNumOfSeats; index++)
            {
                if (String.IsNullOrEmpty(m_nameList[index]))
                    numVacant++;
            }
            return numVacant;
        }
        /// <summary>
        /// returns total number of seats
        /// </summary>
        /// <returns>total number of seats</returns>
        public int GetNumOfSeats()
        {
            return m_totNumOfSeats;
        }
        /// <summary>
        /// Adds a reservation, with name and price from user saved in corresponding array
        /// </summary>
        /// <param name="name">customers name</param>
        /// <param name="price">price of seat</param>
        /// <param name="index">arrayposition</param>
        /// <returns>true if reservation is succesful, false otherwise(if seat already reserved)</returns>
        public bool ReserveSeat(string name, double price, int index)
        {
            if (String.IsNullOrEmpty(m_nameList[index]))
            {
                m_nameList[index] = name;
                m_priceList[index] = price;
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// cancels a reservation, sets name to null and price to 0.0 in arrays
        /// </summary>
        /// <param name="index">array index</param>
        /// <returns>true if succesful, false if seat is already vacant</returns>
        public bool CancelSeat(int index)
        {
            if (!String.IsNullOrEmpty(m_nameList[index]))
            {
                m_nameList[index] = null;
                m_priceList[index] = 0.0d;
                return true;
            }
            else
            {

                return false;
            }
        }
        /// <summary>
        /// Formats and returns a string with info about the seat
        /// </summary>
        /// <param name="index">index of seat</param>
        /// <returns>formatted string containing all info about the seat</returns>
        public string GetSeatInfoAt(int index)
        {
            string strOut = null;
            string strReserved = null;
            string customerName = null;
            string price = null;

            if (!String.IsNullOrEmpty(m_nameList[index]))
            {
                strReserved = "Reserved     ";
                customerName = m_nameList[index];
                price = m_priceList[index].ToString();
            }
            else
                strReserved = "Vacant";



            strOut = string.Format("{0,5} {1,-8} {2,-18} {3,10:f2}", index + 1, strReserved, customerName, price);
            return strOut;
        }
        /// <summary>
        /// Constructs an array containing info about all seats using GetSeatInfoAt-method
        /// </summary>
        /// <returns>array of strings containing seatinfo</returns>
        public string[] GetSeatInfoStrings()
        {
            int count = GetNumOfSeats();

            if (count <= 0)
                return null;
            string[] strSeatInfoStrings = new string[count];

            for (int index = 0; index <= m_totNumOfSeats - 1; index++)
            {
                strSeatInfoStrings[index] = GetSeatInfoAt(index);
            }
            return strSeatInfoStrings;
        }
    }
}
