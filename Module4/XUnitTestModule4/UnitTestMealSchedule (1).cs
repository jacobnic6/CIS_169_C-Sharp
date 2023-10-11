using System;
using Xunit;

namespace XUnitTestMealSchedule
{
    public class UnitTestMealSchedule
    {
        [Fact]
        public void TestMondayLunch()
        {
            // Arrange
            string day = "Monday";
            string mealTime = "lunch";

            string expected = "VeggieBurger and Fries";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMondayDinner()
        {
            // Arrange
            string day = "Monday";
            string mealTime = "dinner";

            string expected = "Lasagna";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTuesdayLunch()
        {
            // Arrange
            string day = "Tuesday";
            string mealTime = "lunch";

            string expected = "Chili and cornbread";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTuesdayDinner()
        {
            // Arrange
            string day = "Tuesday";
            string mealTime = "dinner";

            string expected = "Pizza";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWednesdayLunch()
        {
            // Arrange
            string day = "Wednesday";
            string mealTime = "lunch";

            string expected = "Pad Thai";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWednesdayDinner()
        {
            // Arrange
            string day = "Wednesday";
            string mealTime = "dinner";

            string expected = "Soup and Salad";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestFridayLunch()
        {
            // Arrange
            string day = "Friday";
            string mealTime = "lunch";

            string expected = "Hamburger Helper";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestFridayDinner()
        {
            // Arrange
            string day = "Friday";
            string mealTime = "dinner";

            string expected = "Chicken Parmesan";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSaturdayLunch()
        {
            // Arrange
            string day = "Saturday";
            string mealTime = "lunch";

            string expected = "Macaroni and Cheese";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSaturdayDinner()
        {
            // Arrange
            string day = "Saturday";
            string mealTime = "dinner";

            string expected = "Steak and Potatos";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSundayLunch()
        {
            // Arrange
            string day = "Sunday";
            string mealTime = "lunch";

            string expected = "Eggs and Bacon";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSundayDinner()
        {
            // Arrange
            string day = "Sunday";
            string mealTime = "dinner";

            string expected = "Chicken Alfredo";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestBadInputMealTime()
        {
            // Arrange
            string day = "Tuesday";
            string mealTime = "breakfast";

            string expected = "Ice Cream!";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestBadInputDay()
        {
            // Arrange
            string day = "Blursday";
            string mealTime = "dinner";

            string expected = "Ice Cream!";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
