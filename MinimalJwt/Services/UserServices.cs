using MinimalJwt.Movies;
using MinimalJwt.Repositories;
using System;

namespace MinimalJwt.Services
{
    public class UserServices : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(o => o.Username.Equals(userLogin.Username, StringComparison.OrdinalIgnoreCase) && o.Password.Equals(userLogin.Password));

            return user;
        }
    }
}
