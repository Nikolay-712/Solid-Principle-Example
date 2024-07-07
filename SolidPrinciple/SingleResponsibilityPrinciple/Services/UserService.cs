using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services;

public class UserService
{
    //UserService Class: Handles operations related to users, such as saving and retrieving user information.

    public User GetUserById(int userId) 
    {
        // Code to retrieve user from database
        return new User();
    }

    public void SaveUser(User user)
    {
        // Code to save user to database
    }
}
