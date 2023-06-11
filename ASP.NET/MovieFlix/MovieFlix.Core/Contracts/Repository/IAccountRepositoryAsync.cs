using Microsoft.AspNetCore.Identity;
using MovieFlix.Core.Entities;
using MovieFlix.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFlix.Core.Contracts.Repository
{
    public interface IAccountRepositoryAsync
    {
        Task<IdentityResult> SignUpAsync(SignUpModel user);
        Task<SignInResult> LoginAsync(SignInModel model);

    }
}
