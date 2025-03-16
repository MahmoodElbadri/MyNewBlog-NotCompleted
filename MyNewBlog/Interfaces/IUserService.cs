using MyNewBlog.DTOs;
using MyNewBlog.Models;

namespace MyNewBlog;

public interface IUserService: IGeneralOperations<User>
{
    Task<User> GetUserByUsernameAsync(string username);
    Task<UserResponse> GetBlogsByUserId(Guid id);
}