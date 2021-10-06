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
        public double Feeforhour { get; }
        public double FeeforHour { get; set; }

        public CarParkCharge(int minimumFee=2,int minimumHours=3,double Feeforhour=0.6)
        {
            Console.WriteLine("I am the CarParkCharge");
            this.minimumFee = minimumFee;
            this.minimumHours = minimumHours;
            this.Feeforhour = Feeforhour;
        }

        public override string ToString()
        {
            return "I am the CarParkCharge()";
           
        }

        public int CalculateCharge(int hoursParked)
        {
            int extraHours = hoursParked - minimumHours;
            int fee = minimumFee + extraHours * minimumHours;

            if(fee>=10)
            {
                fee = 10;
            }
            if(hoursParked<=3)
            {
                fee = 2;
            }
            double calculatedFee = hoursParked < minimumHours ? minimumFee : hoursParked * minimumFee;
            return fee;
        }
    }
}
