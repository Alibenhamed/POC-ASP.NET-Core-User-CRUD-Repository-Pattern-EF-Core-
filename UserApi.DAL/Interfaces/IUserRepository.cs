

namespace UserApi.DAL.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    User? GetById(int id);
    bool Create(User user);
    bool Update(User user);
    bool Delete(int id);
}
