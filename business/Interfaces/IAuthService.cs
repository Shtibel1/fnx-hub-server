using BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IAuthService
    {
        Task<string> SignupAsync(AuthForm signUp);
        Task<string> LoginAsync(AuthForm login);
    }
}
