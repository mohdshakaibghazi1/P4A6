using NUnit.Framework;
using Microsoft.AspNetCore.Routing;


namespace UnitTestAssignmentDocker
{
    [TestFixture]
    public class UserValidationTests
    {
        [Test]
        public void TestValidCredentials()
        {
            // Arrange
            UserValidation validator = new UserValidation();
            string validUserId = "john_doe";
            string validPassword = "P@ssw0rd";

            // Act
            bool isValid = validator.ValidateCredentials(validUserId, validPassword);

            // Assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void TestInvalidUserId()
        {
            // Arrange
            UserValidation validator = new UserValidation();
            string invalidUserId = "user123";
            string validPassword = "P@ssw0rd";

            // Act
            bool isValid = validator.ValidateCredentials(invalidUserId, validPassword);

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void TestWeakPassword()
        {
            // Arrange
            UserValidation validator = new UserValidation();
            string validUserId = "john_doe";
            string weakPassword = "password123";

            // Act
            bool isValid = validator.ValidateCredentials(validUserId, weakPassword);

            // Assert
            Assert.IsFalse(isValid);
        }
    }
}