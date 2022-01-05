using MinimalJwt.Movies;

namespace MinimalJwt.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
