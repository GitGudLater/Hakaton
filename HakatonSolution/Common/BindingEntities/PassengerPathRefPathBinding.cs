using Common.Model;

namespace BLL.Implementations.DataAccess.BindingEntities
{
    public class PassengerPathRefPathBinding
    {
        public int PassengerPathRefId { get; set; }
        public PassengerPathRef PassengerPathRef { get; set; }

        public int PathId { get; set; }
        public Path Path { get; set; }
    }
}
