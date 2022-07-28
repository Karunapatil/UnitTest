using NUnit.Framework;
using System;

namespace UnitTest
{
    public class AddTests
    {
        Addition obj = new Addition();

        [Test]
        public void AddTest1()
        {

            //Given
            int num1 = 20;
            int num2 = 10;
            int expectedResult = 30;


            //When
            int actualResult = obj.Add(num1, num2);

            //Then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);

        }


        [Test]
        public void AddTest2()
        {

            //Given
            float num1 = 20.3f;
            float num2 = 10.2f;
            float expectedResult = 30.5f;


            //When
            float actualResult = obj.Add(num1, num2);

            //Then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);

        }
    }
}
