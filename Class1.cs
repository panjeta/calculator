using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace Calculator_test
{
    [TestFixture]
    class Class1
    {
        [Test]
        public void GetDivision_Input8poin0tand4point0_Returns2point0()

        {

            //Arrange
            double number1 = 8.0;
            double number2 = 4.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input6point0and3point0_Returns2point0()

        {

            //Arrange
            double number1 = 6.0;
            double number2 = 3.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void GetDivision_Input8point0and2point0_Returns4point0()

        {

            //Arrange
            double number1 =8.0;
            double number2 = 2.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input4point9and5point9_Returns10point8()

        {

            //Arrange
            double number1 = 4.9;
            double number2 = 5.9;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input6point0and6point0_Returns12point0()

        {

            //Arrange
            double number1 = 6.0;
            double number2 = 6.0;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input6point1and6point1_Returns12point2()

        {

            //Arrange
            double number1 = 6.1;
            double number2 = 6.1;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input9point0and6point0_Returns3point0()

        {

            //Arrange
            double number1 = 9.0;
            double number2 = 6.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input4point2and2point2_Returns2point0()

        {

            //Arrange
            double number1 = 4.2;
            double number2 = 2.2;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input4point2and1point2_Returns3point0()

        {

            //Arrange
            double number1 = 4.2;
            double number2 = 1.2;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Input4point0and2point0_Returns8point0()

        {

            //Arrange
            double number1 = 4.0;
            double number2 = 2.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Input6point0and6point0_Returns36point0()

        {

            //Arrange
            double number1 = 6.0;
            double number2 = 6.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Input3point0and2point0_Returns6point0()

        {

            //Arrange
            double number1 = 3.0;
            double number2 = 2.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
