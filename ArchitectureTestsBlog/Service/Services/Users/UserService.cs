using DataAccess.Repositories;

namespace Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<string> GetUserNames()
        {
            return _userRepository.GetUserNames();
        }
    }
}
