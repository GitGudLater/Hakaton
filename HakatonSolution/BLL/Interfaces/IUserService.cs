using Common.JsonModels;
using Common.Model;

namespace BLL.Interfaces
{
    public interface IUserService : IService<User>
    {
        JsonUser GetJsonUser(int userId);
    }
}
