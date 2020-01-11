using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Model.ORM.Entity.Concrete
{
    public class Shipper : BaseEntity
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public int Phone { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
