using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryTest;


namespace ProjectTest

{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Check_8Char()
        {       
           string password = "12345678";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_4Char()
        {
          
            string password = "1234";
            
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Check_30Char()
        {

            string password = "12345678333333333333333333333333333333333333333333";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_PasswordWithDigits_true()
        {

            string password = "ASDqwe1$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_PasswordWithoutDigits_false()
        {

            string password = "ASDqwASD$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_PasswordWithSpecSimvols_true()
        {

            string password = "Aqwe123$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_PasswordWithSpecSimvols_false()
        {

            string password = "ASDqwe123";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }

    }
}
