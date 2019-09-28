namespace Common.JsonModels
{
    public class JsonPath
    {
        public int Id { get; set; }

        public double NCoordStart { get; set; }
        public double WCoordStart { get; set; }
        public double NCoordEnd { get; set; }
        public double WCoordEnd { get; set; }
        public string StartTime { get; set; }

        public int EmptySeats { get; set; }
        public string Description { get; set; }
        public string Car { get; set; }
        public bool[] Days { get; set; }
    }
}
