using NUnit.Framework;
using System;
namespace UnitTest
{
    public class MulTests
    {
        Multiplication obj = new Multiplication(); [Test]
        public void MulTest1()
        {//given
            int num1 = 20;
            int num2 = 10;
            int expectedResult = 200;

            //when
            int actualResult = obj.Mul(num1, num2);    //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);
        }
        [Test]
        public void MulTest2()
        {  //given
            float num1 = 20.3f;
            float num2 = 10.2f;
            float expectedResult = 207.05998f;
            //when
            float actualResult = obj.Mul(num1, num2);   //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);
        }

    }

}

