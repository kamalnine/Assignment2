using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Vehicle
    {

        private string registrationNumber;
        private string driverName;
        private string vehicleType;
        private float costPerKm;


        public Vehicle()
        {
            Console.WriteLine("CAB REGISTRATION");
        }
        public Vehicle(String rNo,string dName,string vType,float CPK)
        {
        
            registrationNumber = rNo;
            driverName = dName;
            vehicleType = vType;
            costPerKm = CPK;
        }

        public void Display()
        {
            Console.WriteLine("Vehicle Details: ");
            Console.WriteLine("Registration Number : " + registrationNumber);
            Console.WriteLine("Driver name: " + driverName);
            Console.WriteLine("Vehicle Type : " + vehicleType);
            Console.WriteLine("CostPerKm: " + costPerKm);


        }


    }
}
