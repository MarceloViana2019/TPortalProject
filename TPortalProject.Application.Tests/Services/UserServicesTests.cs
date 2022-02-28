using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TPortalProject.Application.DTO;
using TPortalProject.Application.Services;
using TPortalProject.Application.ViewModels;
using TPortalProject.Data.Repositories.Interfaces;
using TPortalProject.Domain.Entities;
using Xunit;

namespace TPortalProject.Application.Tests.Services
{
    public class UserServicesTests
    {
        private UserService userService;

        public UserServicesTests()
        {
            userService = new UserService(new Mock<IUserRepository>().Object);
        }

        #region ValidatingSendingID

        [Fact]
        public void Post_SendingValidId()
        {
            var exception = Assert.Throws<Exception>(() => userService.Post(new UserDTO { Id = 1 }));
            Assert.Equal("Id must be empty", exception.Message);
        }

        #endregion

        #region ValidatingCorrectObject

        [Fact]
        public void Post_SendingValidObject()
        {
            var result = userService.Post(new UserDTO { Name = "Marcelo Viana", Email = "fmsviana@gmail.com" });
            Assert.True(result);
        }

        [Fact]
        public void GetAll_SendingValidObject()
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Name = "Marcelo Viana", Email = "fmsviana@gmail.com" });

            var _userRepository = new Mock<IUserRepository>();
            _userRepository.Setup(x => x.GetAll()).Returns(users);

            userService = new UserService(_userRepository.Object);
            var result = userService.GetAll();
            Assert.True(result.Count > 0);
        }

        #endregion

    }
}
