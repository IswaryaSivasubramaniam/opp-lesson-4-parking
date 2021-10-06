using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Models
{
   public class CarPark
    {
        private List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the CarPark");
        }

        public override string ToString()
        {
            return "I am the CarPark";
              
        }

        public void AddCustomer(Customer newCustomer)
        {
            listOfCustomers.Add(newCustomer);
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedcharge = carParkCharge.CalculateCharge(customer.HoursParked);
                Console.WriteLine($"Calculating charge for customer: cost is {calculatedcharge} euro for registration {customer.Registration}");
            }
        }
    }
}
