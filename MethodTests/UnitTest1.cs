using Xunit;

namespace MethodTests
{
    public class UnitTest1
    {

                //        Include 4 Unit Tests to test ConvertToInt()
                //Test a good value(string can be converted to int)
                //Test an int non-score value(negative)
                //Test a string value(string cannot be converted to int, it's a string "st%$")
                //Test a decimal value (string cannot be converted to int, it's decimal/double)

                //Include 3 Unit Tests to test ValidateInput()
                //Test a good value (int is greater than zero)
                //Test edge case (int is zero)
                //Test bad value(int is less than zero)
        [Fact]
        public void TestStringToInt()
        {
            //Test a good value(string can be converted to int)
            // ARRANGE
            double expected, actual;
            expected = -1;
            string input = "-1";

            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestStringToIntNegativeValue()
        {
            //Test an int non-score value(negative)
            // ARRANGE
            double expected, actual;
            expected = -1;
            string input = "-1";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringtoIntStringValue()
        {
            //Test a string value (string cannot be converted to int, it's a string "st%$")
            // ARRANGE
            double expected, actual;
            expected = -1; // Business Logic 
            string input = "a string";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringtoIntDoubleValue()
        {
            //Test a decimal value (string cannot be converted to int, it's decimal/double)
            // ARRANGE
            double expected, actual;
            expected = -1;
            string input = "1.00";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidateInput()
        {
            // Test a good value(int is greater than zero)
            // ARRANGE
            bool expected, actual;
            expected = true;
            int input = 1;
            // ACT
            actual = Methods.Program.ValidateInput(input);

            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidateInputZero()
        {
            //Test edge case (int is zero)
            // ARRANGE
            bool expected, actual;
            expected = false;
            int input = 0;
            // ACT
            actual = Methods.Program.ValidateInput(input);

            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidateInputNegative()
        {

            //Test bad UnitTest1(int is less than zero)
            // ARRANGE
            bool expected, actual;
            expected = false;
            int inputInt = -5;
            // ACT
            actual = Methods.Program.ValidateInput(inputInt);

            // ASSERT
            Assert.False(Methods.Program.ValidateInput(inputInt));
        }
    }
}
