using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestLearning.Test
{
    [TestClass]
    public class SampleServiceTest
    {

        [TestMethod]
        public void Sum_2_and_2_should_be_4()
        {
            var service = new SampleService();
            var result = service.Sum(2, 2);
            result.Should().Be(4);
        }
        
        [TestMethod]
        public void Subtraction_4_and_2_should_be_2()
        {
            var service = new SampleService();
            var result = service.Subtraction(4, 2);
            result.Should().Be(2);
        }

        [TestMethod]
        public void Multiply_3_and_3_should_be_9()
        {
            var service = new SampleService();
            var result = service.Multiply(3, 3);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Divide_4_and_2_should_be_2()
        {
            var service = new SampleService();
            var result = service.Divide(4, 2);
            result.Should().Be(2);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Divide 4 and 0 should be 0./ </summary>
        /// Returning Zero for dividing by Zero
        /// <remarks>   Hp, 7/12/2023. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void Divide_4_and_0_should_be_0()
        {
            var service = new SampleService();
            var result = service.Divide(4, 0);
            result.Should().Be(0);
        }
    }
}
