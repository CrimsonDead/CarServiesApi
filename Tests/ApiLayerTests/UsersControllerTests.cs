using DataLayer.Models;
using ApiLayer.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Tests.ApiLayerTests
{
    [TestClass]
    public class UsersControllerTests
    {
        private UsersController _userContreller;
        private User _user;

        [ClassInitialize]
        public void ClassInitialize()
        {
            var mockUserManager = new Mock<UserManager<User>>();
            var mockSignInManager = new Mock<SignInManager<User>>();

            //mockUserManager.Setup(um => um.Get)

            _userContreller = new UsersController(mockUserManager.Object, mockSignInManager.Object);
            _user = new User();
            _user.UserName = "test user";
            _user.Email = "testmail@gmail.com";
        }
        [TestMethod]
        public void RegisterPerformsWithCode200()
        {
            var expected = _userContreller.Ok();

            var result = _userContreller.Register(_user, Role.Client.ToString(), "XXXZXC");

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }
    }
}
