using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.Models
{
    public class CarParkCharge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }

        public CarParkCharge(int minimumFee=2,int minimumHours=3)
        {
            Console.WriteLine("I am the CarParkCharge");
            this.minimumFee = minimumFee;
            this.minimumHours = minimumHours;
        }

        public override string ToString()
        {
            return "I am the CarParkCharge()";
           
        }

        public int CalculateCharge(int hoursParked)
        {
            
            int calculatedFee = hoursParked < minimumHours ? minimumFee : hoursParked * minimumFee;
            return calculatedFee;
        }
    }
}
