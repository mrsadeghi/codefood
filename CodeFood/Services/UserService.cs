using CodeFood.Helper;
using CodeFood.Models;
using CodeFood.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFood.Services
{
    public class UserService:IUserService
    {
        private readonly CodeFoodContext _context;
        public UserService(CodeFoodContext context)
        {
            _context = context;
        }

        public bool Register(UserRegisterVM model)
        {
            #region validation
            if (string.IsNullOrEmpty(model.FirstName))
                throw new CodeFoodException("FirstName is Required");
            if (string.IsNullOrEmpty(model.LastName))
                throw new CodeFoodException("LastName is Required");
            if (string.IsNullOrEmpty(model.Email))
                throw new CodeFoodException("Email is Required");
            if (string.IsNullOrEmpty(model.PhoneNumber))
                throw new CodeFoodException("PhoneNumber is Required");
            if (string.IsNullOrEmpty(model.LinkedInUrl))
                throw new CodeFoodException("LinkedInUrl is Required");

            if (!new EmailAddressAttribute().IsValid(model.Email))
                throw new CodeFoodException("Email is Invalid");

            if (_context.Users.Any(t => t.Email == model.Email))
            {
                throw new CodeFoodException("This email has been registered before");
            }
            if (_context.Users.Any(t => t.PhoneNumber == model.PhoneNumber))
            {
                throw new CodeFoodException("This phone number has been registered before");
            }
            if (_context.Users.Any(t => t.LinkedInUrl == model.LinkedInUrl))
            {
                throw new CodeFoodException("This LinkedIn Url has been registered before");
            }
            #endregion

            try
            {
                _context.Users.Add(new User
                {
                    Email = model.Email,
                    LinkedInUrl = model.LinkedInUrl,
                    PhoneNumber = model.PhoneNumber,
                    LastName = model.LastName,
                    FirstName = model.FirstName,
                    CreateDate=DateTime.Now,
                    IsActive=false,
                    IsDeleted=false
                });

                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public interface IUserService
    {
        bool Register(UserRegisterVM model);
    }
}
