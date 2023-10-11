using System;
using Xunit;
using AddressClass;

namespace XUnitTestProject1
{
 
    public class UnitTestAddress
    {
        [Fact]
        public void TestAddressClass()
        {
            // ARRANGE
            string actual, expected = "123 Main Street Apt H2\nSmall Town, Iowa 55555"; 
;
            Address testAddy = new Address(123, "Main Street", "H2", "Small Town", "Iowa", 55555);
            // ACT
            actual = testAddy.ToString(); 
            // ASSERT 
            Assert.Equal(expected, actual);

        }

    }
}
