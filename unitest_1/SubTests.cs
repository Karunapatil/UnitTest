using NUnit.Framework;
using System;

namespace UnitTest
{
    public class SubTests
    {
        Substraction obj = new Substraction();

        [Test]
        public void SubTest1()
        {

            //Given
            int num1 = 20;
            int num2 = 10;
            int expectedResult = 10;


            //When
            int actualResult = obj.Sub(num1, num2);

            //Then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);

        }


        [Test]
        public void SubTest2()
        {

            //Given
            float num1 = 20.3f;
            float num2 = 10.2f;
            float expectedResult = 10.0999994f;


            //When
            float actualResult = obj.Sub(num1, num2);

            //Then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);

        }
    }
}