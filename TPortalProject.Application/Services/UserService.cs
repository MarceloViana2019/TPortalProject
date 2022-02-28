using System;
using System.Collections.Generic;
using System.Text;
using TPortalProject.Application.DTO;
using TPortalProject.Application.Interfaces;
using TPortalProject.Application.ViewModels;
using TPortalProject.Data.Repositories.Interfaces;
using TPortalProject.Domain.Entities;

namespace TPortalProject.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserViewModel> GetAll()
        {
            var userViewModels = new List<UserViewModel>();

            var users = _userRepository.GetAll();

            foreach (var item in users)
                userViewModels.Add(new UserViewModel { });

            return userViewModels;
        }

        public User Post(UserDTO userDTO)
        {
            var user = new User();
            //Implementar AutoMapper

            var result = _userRepository.Create(user);

            return result;
        }

        public UserViewModel GetById(int Id)
        {
            var user = _userRepository.Get(Id);

            if (user == null)
                throw new Exception("User not found");

            //Implementar AutoMapper

            var userViewModel = new UserViewModel();

            return userViewModel;

        }
    }
}
