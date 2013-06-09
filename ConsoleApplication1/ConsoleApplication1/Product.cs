using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatCalculator
{
    class Product
    {
        private string name;
        private int count;
        private double unitPrice;
        private bool isFoodItem;

        private double totalVat;
        private double totalValue;

        private const double foodVATrate = 0.12, otherVATrate = 0.25;

        //Method called from GroceryStore
        public void Start()
        {
            ReadInput();
            CalculateValue();
            PrintReceipt();
        }

        //Read info from user
        private void ReadInput()
        {
            ReadName();
            NetUnitPrice();
            ReadFoodItem();
            ReadCount();
        }

        //Calculate total price and VAT
        private void CalculateValue()
        {
            double value = unitPrice * count;

            if (isFoodItem)
                totalVat = value * foodVATrate;
            else
                totalVat = value * otherVATrate;

            totalValue = value + totalVat;
        }

        //Print out user receipt
        private void PrintReceipt()
        {
            Console.WriteLine("**************RECEIPT**************");
            Console.WriteLine("Name of product:         " + name);
            Console.WriteLine("Quantity:                " + count);
            Console.WriteLine("Unit Price:              " + unitPrice);
            Console.WriteLine("Food item:               " + isFoodItem);
            Console.WriteLine();
            Console.WriteLine("Total amount to pay:     " + totalValue);
            if (isFoodItem)
                Console.WriteLine("Including VAT at 12%:    " + totalVat);
            else
                Console.WriteLine("Including VAT at 25%:    " + totalVat);
            Console.WriteLine();
            Console.WriteLine("Program developed by Anton Forsberg");
            Console.WriteLine("**************THANKYOU**************");
        }

        //Reads the productname
        private void ReadName()
        {
            Console.WriteLine("Please type the name of your product:");
            name = Console.ReadLine();
        }

        //Reads price of product
        private void NetUnitPrice() 
        {
            Console.WriteLine("What is the price of your item?");
            string price = Console.ReadLine();

            try
            {
                unitPrice = Convert.ToDouble(price);
            }
            catch (FormatException)
            {
                Console.WriteLine(price + " is not a valid input");
                NetUnitPrice();
            }
            
        }
        //reads if food item or not
        private void ReadFoodItem()
        {
            Console.WriteLine("Is it a fooditem? (y/n): ");

            char response = char.Parse(Console.ReadLine());

            if ((response == 'y') || (response == 'Y'))
                isFoodItem = true;
            else
                isFoodItem = false;

        }

        //Reads quantity
        private void ReadCount()
        {
            Console.WriteLine("How many " +name +" do you want to buy?");
            string response = Console.ReadLine();

            try
            {
                count = Convert.ToInt16(response);
            }
            catch (FormatException)
            {
                Console.WriteLine(response + " is not a valid input");
                ReadCount();
            }
        }

    }
}
