using Common.Model;

namespace BLL.Implementations.DataAccess.BindingEntities
{
    public class PassengerPathRefUserBinding
    {
        public int PassengerPathRefId { get; set; }
        public PassengerPathRef PassengerPathRef { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
