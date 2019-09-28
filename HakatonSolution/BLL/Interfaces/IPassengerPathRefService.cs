using Common.Model;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IPassengerPathRefService : IService<PassengerPathRef>
    {
        List<PassengerPathRef> GetPassengersList(int pathId);
    }
}
