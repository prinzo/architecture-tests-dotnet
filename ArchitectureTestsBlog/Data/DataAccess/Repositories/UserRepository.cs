namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<string> GetUserNames()
        {
            return new List<string>
            {
                "John",
                "Doe"
            };
        }
    }
}
