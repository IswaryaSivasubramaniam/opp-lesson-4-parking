using opp_lesson_4_parking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.test
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }

        public void CreateObjects()
        {
            CarPark carpark = new CarPark();


            carpark.AddCustomer(new Customer("a",2));
            carpark.AddCustomer(new Customer("b",3));
            carpark.AddCustomer(new Customer("c",4));
            carpark.AddCustomer(new Customer("d",5));
            carpark.AddCustomer(new Customer("e",6));
            carpark.AddCustomer(new Customer("f",7));

            carpark.CalculateCharges();



            Customer customer = new Customer("g",8);
            CarParkCharge carparkcharge = new CarParkCharge();

            // call the ToString method

            Console.WriteLine(carpark.ToString());

            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());


        }
    }
}
