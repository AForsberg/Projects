using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class SeatManager
    {

        private readonly int m_totSeats = 0;    //number of seats in the cinema
        private string[] m_nameList;
        private string[] m_priceList;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxNumOfSeats">value for m_totSeats</param>
        public SeatManager(int maxNumOfSeats)
        {
            m_totSeats = maxNumOfSeats; //assigning the value to m_totSeats

            m_nameList = new string[m_totSeats];
            m_priceList = new string[m_totSeats];

        }
        /// <summary>
        /// Checks if the index is valid
        /// </summary>
        /// <param name="index">index to be checked</param>
        /// <returns>true if valid, false otherwise</returns>
        private bool CheckIndex(int index)
        {
            if (index < m_totSeats && index >= 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Loops through nameList array and checks for reserved slots (indexes that ar not null or empty)
        /// </summary>
        /// <returns>number of reserved seats</returns>
        public int GetNumReserved()
        {
            int numReserved = 0;
            for (int i = 0; i < m_nameList.Length; i++)
            {
                if(!String.IsNullOrEmpty(m_nameList[i]))
                    numReserved++;

            }
            return numReserved;
        }

    }
}
