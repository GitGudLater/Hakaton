namespace Common.Model
{
    public class Path
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WeekGraphicId { get; set; }

        public double NCoordStart { get; set; }
        public double WCoordStart { get; set; }
        public double NCoordEnd { get; set; }
        public double WCoordEnd { get; set; }
        public string StartTime { get; set; }

        public int MaxSeads { get; set; }
        public int OccupiedSeads { get; set; }

        public string Description { get; set; }
    }
}
