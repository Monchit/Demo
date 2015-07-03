using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DeviceItem : Device //Inherit Device
    {
        public string Name { get; set; }
        public int Watts { get; set; }
        public double HoursPerDay { get; set; }
        public double DaysPerMonth { get; set; }

        public override double UnitsPerMonth // Add keyword override
        {
            get
            {
                //throw new NotImplementedException();//Not Coding
                //var units = (Watts * HoursPerDay * DaysPerMonth) / 1000;
                //var units = 0.0;
                //if (Watts >= 0 && HoursPerDay >= 0 && DaysPerMonth >= 0)
                //{
                //    units = (Watts * HoursPerDay * DaysPerMonth) / 1000;
                //}
                if (Watts < 0 || HoursPerDay < 0 || DaysPerMonth < 0)
                {
                    throw new Exception("Invalid data.");
                }
                var units = (Watts * HoursPerDay * DaysPerMonth) / 1000;
                return units;
            }
        }
    }
}
