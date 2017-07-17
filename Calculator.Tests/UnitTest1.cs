using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }

        [Fact]
        public void SubtractTwoIntegers()

        {
            int sub = _calculator.sub(85, 28);
            Assert.Equal(sub, 57 );
        }
        
        [Fact]
        public void multiplyTwoIntegers()
        {
         int multiply = _calculator.multiply(20, 50);
         Assert.Equal (multiply, 1000);


        }

        [Fact]
        public void divideTwoIntegers()
            {
            int divide = _calculator.divide(20, 5);
            Assert.Equal (divide, 4);
            
            }

        

        
        
            
        
    }
}
