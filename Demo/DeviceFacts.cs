using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Should;

namespace Demo
{
    public class DeviceFacts
    {
        public class TheUnitsPerMonthProperty
        {

            [Fact]
            public void MyNotebook()
            {
                var d = new DeviceItem();
                d.Name = "Notebook";
                d.Watts = 65;
                d.HoursPerDay = 10;
                d.DaysPerMonth = 20;

                var units = d.UnitsPerMonth;

                //Assert.Equal(13.0, units);
                units.ShouldEqual(13.0);//Use Should
            }

            [Fact]
            public void MyTV()
            {
                var d = new DeviceItem();
                d.Name = "TV";
                d.Watts = 1000;
                d.HoursPerDay = 2;
                d.DaysPerMonth = 30;

                var units = d.UnitsPerMonth;

                Assert.Equal(60.0, units);
            }

            [Fact]
            public void AllSupportiveDataShouldNotBeNegative()
            {
                var d = new DeviceItem();
                d.Name = "TV";
                d.Watts = -1000;
                d.HoursPerDay = -2;
                d.DaysPerMonth = 30;

                var ex = Assert.ThrowsAny<Exception>(() =>
                {
                    var units = d.UnitsPerMonth;
                });

                Assert.Equal("Invalid data.", ex.Message);
            }
        }
    }
}
