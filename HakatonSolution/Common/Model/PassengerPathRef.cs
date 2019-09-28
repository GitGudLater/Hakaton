using BLL.Implementations.DataAccess.BindingEntities;
using System.Collections.Generic;

namespace Common.Model
{
    public class PassengerPathRef
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PathId { get; set; }

        public ICollection<PassengerPathRefPathBinding> PassengerPathRefPathBindings { get; set; }
        public ICollection<PassengerPathRefUserBinding> PassengerPathRefUserBindings { get; set; }

        public PassengerPathRef()
        {
            PassengerPathRefPathBindings = new List<PassengerPathRefPathBinding>();
            PassengerPathRefUserBindings = new List<PassengerPathRefUserBinding>();
        }
    }
}
