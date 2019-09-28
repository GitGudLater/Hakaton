namespace Common.JsonModels
{
    public class JsonPath
    {
        public int Id { get; set; }
        
        public string CoordStart { get; set; }
        public string CoordFin { get; set; }
        public string TBegin { get; set; }

        public int EmptySeats { get; set; }
        public string Description { get; set; }
        public string Car { get; set; }
        public bool[] Days { get; set; }
    }
}
