using Common.JsonModels;
using Common.Model;

namespace BLL.Interfaces
{
    public interface IWeekGraphicService : IService<WeekGraphic>
    {
        JsonDayStrings GetJsonDayStrings(bool[] days);
    }
}
