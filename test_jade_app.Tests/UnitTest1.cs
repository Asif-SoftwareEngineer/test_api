using System;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_jade_app.Models;
using test_jade_app.Controllers;

namespace test_jade_app.Tests
{
    [TestClass]
    public class TestUserController
    {
        [TestMethod]
        public void SaveUser_ShouldReturnCorrectDataInvalidationMessage()
        {
            var testUser = new User { FirstName = "Asif", LastName = "Javed", Address = "Bourke Street", Age = 35, Suburb = "Melbourne", State = "VIC", PostCode = "3029", Country = "au" };

            var controller = new UserController()
        }
    }
}
