 using Microsoft.AspNetCore.Identity;
using MovieFlix.Core.Contracts.Repository;
using MovieFlix.Core.Entities;
using MovieFlix.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Infrastructure.Repository
{
    public class AccountRepositoryAsync : IAccountRepositoryAsync
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        public AccountRepositoryAsync(UserManager<User> m, SignInManager<User> signInManager)
        {
            userManager = m;
            this.signInManager = signInManager;
        }
        public Task<IdentityResult> SignUpAsync(SignUpModel user)
        {
            //we do not specify password here because we will encrypt it.

            var appUser = new User()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.Email,
                DateOfBirth = user.DateOfBirth,
                PhoneNumber = user.PhoneNumber,
                LastLoginDateTime = DateTime.Now
            };
             
            // Password encryption done by Microsoft Identity.
            return userManager.CreateAsync(appUser, user.Password);

            //return Task.FromResult(IdentityResult.Success);
        }

        public Task<SignInResult> LoginAsync(SignInModel model)
        {
            // Email, Password, Remember the info, LockoutOnFailure
            
            return signInManager.PasswordSignInAsync(model.Email, model.Password, model.Remember, false);
        }


    }
}
