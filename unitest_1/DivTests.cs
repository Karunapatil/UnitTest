using NUnit.Framework;
using System;

namespace UnitTest
{
    public class DivTests
    {
        Division obj = new Division();

        [Test]
        public void DivTest1()
        {

            //Given
            int num1 = 20;
            int num2 = 10;
            int expectedResult = 2;


            //When
            int actualResult = obj.Div(num1, num2);

            //Then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);

        }


        [Test]
        public void DivTest2()
        {

            //Given
            float num1 = 20.3f;
            float num2 = 10.2f;
            float expectedResult = 1.990196f;


            //When
            float actualResult = obj.Div(num1, num2);

            //Then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);

        }
    }
}
