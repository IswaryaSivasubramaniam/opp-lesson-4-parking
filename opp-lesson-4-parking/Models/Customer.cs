using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Models
{
    public class Customer
    {
        public int hoursParked { get; set; }
        public string Registration { get; set; }

        public Customer(string registration,int _hoursParked )
        {
            Console.WriteLine("I am the Customer");
            Registration = registration;
            HoursParked = _hoursParked;
           
        }

        public int HoursParked { get; }

        public override string ToString()
        {
            return "I am the Customer";
            
             
        }
    }
}
