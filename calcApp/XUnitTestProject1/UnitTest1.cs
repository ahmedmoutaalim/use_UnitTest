using calcApp;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
       

        [Fact]
        public void Test1()
        {

            //Arrang
            var expt = 10;
            var val1 = 3;
            var val2 = 7;
            //Act
            var result = new calcOperation();
            var imp = result.somme(val1, val2);
            //Assert

            Assert.Equal(expt, imp);


        }
    }
}
