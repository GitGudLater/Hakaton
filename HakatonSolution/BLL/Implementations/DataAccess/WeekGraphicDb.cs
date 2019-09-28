using Common.Model;

namespace BLL.Implementations.DataAccess
{
    public class WeekGraphicDb
    {
        public int Id { get; set; }

        public bool Day1 { get; set; }
        public bool Day2 { get; set; }
        public bool Day3 { get; set; }
        public bool Day4 { get; set; }
        public bool Day5 { get; set; }
        public bool Day6 { get; set; }
        public bool Day7 { get; set; }

        public WeekGraphic ToWeekGraphic()
        {
            bool[] days = new bool[] { Day1, Day2, Day3, Day4, Day5, Day6, Day7, };
            return new WeekGraphic() { Id = this.Id, Days = days};
        }

        public static WeekGraphicDb ParseToDbVersion(WeekGraphic graphic)
        {
            WeekGraphicDb result = new WeekGraphicDb
            {
                Id = graphic.Id,
                Day1 = graphic.Days[0],
                Day2 = graphic.Days[1],
                Day3 = graphic.Days[2],
                Day4 = graphic.Days[3],
                Day5 = graphic.Days[4],
                Day6 = graphic.Days[5],
                Day7 = graphic.Days[6],
            };

            return result;
        }
    }
}
