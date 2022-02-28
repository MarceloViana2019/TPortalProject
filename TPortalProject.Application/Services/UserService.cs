using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPortalProject.Application.DTO;
using TPortalProject.Application.Interfaces;
using TPortalProject.Application.ViewModels;
using TPortalProject.Auth.Services;
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

            if (users.Any())
            {
                foreach (var item in users)
                    userViewModels.Add(new UserViewModel { });
            }

            return userViewModels;
        }

        public bool Post(UserDTO userDTO)
        {
            if (userDTO.Id != 0)
                throw new Exception("Id must be empty");

            var user = new User();
            //Implementar AutoMapper

            _userRepository.Create(user);

            return true;
        }

        public UserViewModel GetById(int Id)
        {
            var user = _userRepository.Get(Id);

            if (user == null)
                throw new Exception("User not found");

            //Implementar AutoMapper e carregar objeto

            var userViewModel = new UserViewModel();

            return userViewModel;
        }

        public UserAuthResponseViewModel Authenticate(UserAuthRequestDTO userDTO)
        {
            //var user = _userRepository.Find(x => !x.IsDeleted && x.Email.ToLower() == userDTO.Email.ToLower());
            //if (user == null)
            //    throw new Exception("User not found");

            //Moq de objeto do banco de dados
            var user = new User()
            {
                Id = 1,
                Name = "Marcelo Viana",
                Email = "fmsviana@gmail.com"
            };
            //Implementar AutoMapper e carregar objeto
            var userViewModel = new UserViewModel() { 
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };

            return new UserAuthResponseViewModel(userViewModel, TokenService.GenerateToken(user));

        }
    }
}
