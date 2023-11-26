using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON12._3___Interfaces
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            if (vehicle.startingGasoline > 0)
            {
                vehicle.Drive();
            }
            else
            {
                Console.WriteLine("You have no fuel. Enter the amount of fuel:");
                vehicle.Refuel(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Fuel amount = {vehicle.startingGasoline}");
                vehicle.Drive();
            }
        }
    }
    class Vehicle : IVehicle
    {
        public int startingGasoline;
        public Vehicle()
        {
            startingGasoline = 0;
        }
       public void Drive()
        {
            Console.WriteLine("The Car is driving..."); 
        }
        public bool Refuel(int gasoline)
        {
            bool result;
            startingGasoline += gasoline;

            if (startingGasoline > 0) 
            { 
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}

