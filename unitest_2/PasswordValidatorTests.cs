using NUnit.Framework;
using System;
namespace UnitTest
{
    public class PasswordValidatorTests
    {
        PasswordValidator obj = new PasswordValidator(); [Test]
        public void PasswordLengthTest()
        {
            //given
            String password = "Test@1234";
            bool expectedResult = true;    //when
            bool actualResult = obj.PasswordLength(password);    //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            Console.WriteLine(actualResult);

        }
    }
}