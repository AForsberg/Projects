//By Anton Forsberg
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class InputUtility
    {

        /// <summary>
        /// Validates and converts a textinput of a value into an integer
        /// </summary>
        /// <param name="stringToConvert">string containing the value to be converted.
        /// if not a valid entry is set to zero</param>
        /// <param name="intOutValue">the converted value</param>
        /// <returns>true if succesful conversion, otherwise false</returns>
        public static bool GetInteger(string stringToConvert, out int intOutValue)
        {
            bool goodNumber = int.TryParse(stringToConvert, out intOutValue);
            return goodNumber;
        }
        
        /// <summary>
        /// Validates and converts a textinput representing a  positive value into an integer
        /// </summary>
        /// <param name="stringToConvert">containing value to be converted</param>
        /// <param name="intOutValue">converted value</param>
        /// <returns>true if conversion was succesful, false otherwise</returns>
        public static bool GetPositiveInteger(string stringToConvert, out int intOutValue)
        {
            bool goodNumber = int.TryParse(stringToConvert, out intOutValue);
            if (goodNumber && intOutValue >= 0)
                return goodNumber;
            return false;
        }

        /// <summary>
        /// Validates and converts a textinput representing a value into a double
        /// </summary>
        /// <param name="stringToConvert">string containing value to be converted</param>
        /// <param name="dblOutValue">converted value</param>
        /// <returns>true if conversion was succesful, false otherwise</returns>
        public static bool GetDouble(string stringToConvert, out double dblOutValue)
        {
            bool goodDouble = double.TryParse(stringToConvert, out dblOutValue);
            return goodDouble;
        }

        /// <summary>
        /// Validates and converts a textinput representing a  positive value into a double
        /// </summary>
        /// <param name="stringToConvert">string containing value to be converted</param>
        /// <param name="dblOutValue">converted double</param>
        /// <returns>true if conversion was succesful, false otherwise</returns>
        public static bool GetPositiveDouble(string stringToConvert, out double dblOutValue)
        {
            bool goodDouble = double.TryParse(stringToConvert, out dblOutValue);
            if(goodDouble && (dblOutValue >= 0.0))           
                return goodDouble;
            return false;
        }

        /// <summary>
        /// Checks a string to see that is not null or empty when trimmed(leading and traling spaces removed)
        /// </summary>
        /// <param name="StringToCheck">the string to be checked</param>
        /// <returns>true if the string is not null or empty after trim, false otherwise</returns>
        public static bool ValidateString(string StringToCheck)
        {
            string strIn = StringToCheck.Trim();

            return !string.IsNullOrEmpty(strIn);
        }


    }
}
