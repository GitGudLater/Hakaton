using Common.JsonModels;
using Common.Model;

namespace BLL.Interfaces
{
    public interface IPathService : IService<Path>
    {
        JsonPath GetJsonPath(int pathId);
    }
}
