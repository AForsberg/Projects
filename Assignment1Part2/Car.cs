using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    class Car
    {
        private String model;
        private double tankSize;
        private double fuelConsumption;
        private double price;
        private string fuelType;

        private double priceDiesel = 14.10;
        private double priceGas = 14.30;

        private double range;
        private double fillCost;

        public void Start()
        {
            readInput();
            calculateRange();
            calculateFillCost();
            printInfo();

        }


        private void calculateFillCost()
        {
            if (fuelType == "gas")
                fillCost = tankSize * priceGas;
            else
                fillCost = tankSize * priceDiesel;
        }

        private void calculateRange()
        {
            range = (tankSize / fuelConsumption) * 10;
        }

        private void readInput()
        {
            readModel();
            readTankSize();
            readConsumption();
            readPrice();
            readFuelType();
        }

        private void readConsumption()
        {
            string response;
            Console.WriteLine("What is the cars fuel consumption? (In liters/10km)");
            response = Console.ReadLine();
            try
            {
                fuelConsumption = Convert.ToDouble(response);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry, try again.");
                readConsumption();

            }
        }

        private void readFuelType()
        {
            string response;
            Console.WriteLine("Does the car run on gas or diesel?");
            response = Console.ReadLine();

            if (response.Equals("gas") || response.Equals("Gas"))
                fuelType = "gas";
            else if (response.Equals("diesel") || response.Equals("Diesel"))
                fuelType = "diesel";
            else
            {
                Console.WriteLine("Invalid entry, try again.");
                readFuelType();
            }

        }

        private void readModel()
        {
            Console.WriteLine("What model is the car?");
            model = Console.ReadLine();
        }

        private void readPrice()
        {
            string response;
            Console.WriteLine("What is the price of the car? (In kr)");
            response = Console.ReadLine();
            try
            {
                price = Convert.ToDouble(response);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry, try again.");
                readPrice();
            }
        }

        private void readTankSize()
        {
            string response;
            Console.WriteLine("How much fuel does the tank hold? (in liters)");
            response = Console.ReadLine();
            try
            {
                tankSize = Convert.ToDouble(response);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry, try again.");
                readTankSize();

            }
        }

        private void printInfo()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Car info: ");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Fueltype: " + fuelType);
            Console.WriteLine("Range: " + range + " km/tank");
            Console.WriteLine("Price to fill tank: " + fillCost + " kr");
            Console.WriteLine("Developed by Anton Forsberg");
            Console.WriteLine("*************************************************");
        }






    }
}
