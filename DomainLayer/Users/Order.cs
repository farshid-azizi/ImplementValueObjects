using DomainLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Users
{
    public partial class Order : BaseEntity<Guid>
    {
        // Empty constructor in this case is required by EF Core,
        // because has a complex type as a parameter in the default constructor.
        private Order() 
        {
            // Only for EF
        }
        public string Username { get; private set; }
        public Order(Guid id) : base(id)
        {
        }

        public Address Address { get; private set; }
    }
}
