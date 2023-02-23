using CalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLibrary.Test
{
    public class CalcutalionsTestClass
    {
        [Theory]
        [InlineData(2,3,5)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            Calculations calc = new Calculations();
            double actual = calc.Add(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
