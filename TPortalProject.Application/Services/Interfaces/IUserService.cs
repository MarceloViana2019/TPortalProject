using System;
using System.Collections.Generic;
using System.Text;
using TPortalProject.Application.DTO;
using TPortalProject.Application.ViewModels;
using TPortalProject.Domain.Entities;

namespace TPortalProject.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> GetAll();
        bool Post(UserDTO user);
        UserViewModel GetById(int Id);
        UserAuthResponseViewModel Authenticate(UserAuthRequestDTO userDTO);
    }
}
