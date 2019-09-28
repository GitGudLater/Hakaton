using BLL.Implementations.DataAccess.BindingEntities;
using System.Collections.Generic;

namespace Common.Model
{
    public class PassengerPathRef
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PathId { get; set; }

        public ICollection<PassengerPathRefPathUserBinding> PassengerPathRefPathUserBindings { get; set; }

        public PassengerPathRef()
        {
            PassengerPathRefPathUserBindings = new List<PassengerPathRefPathUserBinding>();
        }
    }
}
