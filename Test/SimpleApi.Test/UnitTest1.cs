using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        private readonly WeatherForecastController sut= new WeatherForecastController();

           
        [Fact]
        public void Test1()
        {
          var result=  sut.Get();
            Assert.NotNull(result);
        }
    }
}
