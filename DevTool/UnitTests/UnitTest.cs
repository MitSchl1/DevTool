using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevTool
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            Addition a = new Addition();
            double result = a.CalcWithTwoPassedValues(2, 2);
            Assert.Equal(4, result);
        }
    }
}
