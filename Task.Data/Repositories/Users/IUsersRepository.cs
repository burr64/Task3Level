namespace Task.Data.Repositories.Users;

public interface IUsersRepository
{
    Task<IEnumerable<Users>> GetAllUsersAsync();
    Task<Users> GetUserByIdAsync(int id);
    Task CreateAsync(Users user);
    Task UpdateAsync(Users user);
    Task DeleteAsync(int id);
}