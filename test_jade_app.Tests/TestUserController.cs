using System;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_jade_app.Models;
using test_jade_app.Controllers;
using System.Web.Http;



namespace test_jade_app.Tests
{
    [TestClass]
    public class TestUserController
    {
        [TestMethod]
        public void SaveUser_ShouldReturnValidUserObject()
        {
            var testUser = new User { FirstName = "Asif", LastName = "Javed", Address = "Bourke Street", Age = 35, Suburb = "Melbourne", State = "VIC", PostCode = "3029", Country = "au" };

            var controller = new UserController(testUser);

            
            Assert.IsNotNull(testUser, "test user is fully initialized");

            IHttpActionResult result = controller.SaveUser(testUser);
            OkNegotiatedContentResult<User> negResult = result as OkNegotiatedContentResult<User>;
            Assert.IsNotNull(negResult);
            Assert.AreEqual<string>(testUser.FirstName, negResult.Content.FirstName);

        }

        [TestMethod]
        public void SaveUser_ShouldReturnWithFirstNameInvalidMessage()
        {
            var testUser = new User { FirstName = "", LastName = "Javed", Address = "Bourke Street", Age = 35, Suburb = "Melbourne", State = "VIC", PostCode = "3029", Country = "au" };

            var controller = new UserController(testUser);


            Assert.IsNotNull(testUser, "test user is initialized with first name as empty");

            IHttpActionResult result = controller.SaveUser(testUser);
            BadRequestErrorMessageResult negResult = result as BadRequestErrorMessageResult;
            Assert.AreEqual("FirstName invalid", negResult.Message);
        }

        [TestMethod]
        public void SaveUser_ShouldReturnWithLastNameInvalidMessage()
        {
            var testUser = new User { FirstName = "Asif", LastName = "", Address = "Bourke Street", Age = 35, Suburb = "Melbourne", State = "VIC", PostCode = "3029", Country = "au" };

            var controller = new UserController(testUser);


            Assert.IsNotNull(testUser, "test user is initialized with first name as empty");

            IHttpActionResult result = controller.SaveUser(testUser);
            BadRequestErrorMessageResult negResult = result as BadRequestErrorMessageResult;
            Assert.AreEqual("LastName invalid", negResult.Message);


        }
    }
}
