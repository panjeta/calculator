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
        public void GetAddition_Input3point9and5point9_Returns9point0()
       
        {

            //Arrange
            double number1 = 3.9;
            double number2 = 5.9;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
         [Test]
        public void GetAddition_Input4point2and5point2_Returns9point0()

        {

            //Arrange
            double number1 = 4.2;
            double number2 = 5.2;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        
        }

        [Test]
        public void GetAddition_Input4point8and5point8_Returns9point0()

        {

            //Arrange
            double number1 = 4.8;
            double number2 = 5.8;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
