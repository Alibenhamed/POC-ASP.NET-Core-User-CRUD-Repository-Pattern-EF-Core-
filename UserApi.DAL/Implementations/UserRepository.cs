

namespace UserApi.DAL.Implementations;

public class UserRepository : IUserRepository

{
    private readonly PocDbContext _context;

    public UserRepository(PocDbContext context)
    {
        _context = context;
    }

    public bool Create(User user)
    {
        _context.Users.Add(user);
        return _context.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) return false;

        _context.Users.Remove(user);
        return _context.SaveChanges() > 0;
    }

    public async Task<List<User>> GetAllAsync()
    {
        var liste = await _context.Users.ToListAsync();
        return liste;
    }

    public User? GetById(int id)
    {
        return _context.Users.Find(id);
    }

    public bool Update(User user)
    {
        _context.Users.Update(user);
        return _context.SaveChanges() > 0;
    }
}