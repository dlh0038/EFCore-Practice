using Microsoft.EntityFrameworkCore;
//this class contains the CRUD operations
public class UserServices
{
    #region Private members
    private UserDbContext dbContext;
    #endregion

    #region Constructor
    public UserServices(UserDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Public methods
    /// <summary>
    /// This method returns the list of User
    /// </summary>
    /// <returns></returns>
    public async Task<List<User>> GetUserAsync()
    {
        return await dbContext.User.ToListAsync();
    }

    /// <summary>
    /// This method add a new User to the DbContext and saves it
    /// </summary>
    /// <param name="User"></param>
    /// <returns></returns>
    public async Task<User> AddUserAsync(User User)
    {
        try
        {
            dbContext.User.Add(User);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return User;
    }

    /// <summary>
    /// This method update and existing User and saves the changes
    /// </summary>
    /// <param name="User"></param>
    /// <returns></returns>
    public async Task<User> UpdateUserAsync(User User)
    {
        try
        {
            var UserExist = dbContext.User.FirstOrDefault(p => p.Id == User.Id);
            if (UserExist != null)
            {
                dbContext.Update(User);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return User;
    }

    /// <summary>
    /// This method removes and existing User from the DbContext and saves it
    /// </summary>
    /// <param name="User"></param>
    /// <returns></returns>
    public async Task DeleteUserAsync(User User)
    {
        try
        {
            dbContext.User.Remove(User);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}