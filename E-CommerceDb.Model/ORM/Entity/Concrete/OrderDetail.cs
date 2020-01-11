using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Model.ORM.Entity.Concrete
{
    public class OrderDetail : BaseEntity
    {

        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }


        public int OrderID { get; set; }
        public virtual Order Orders { get; set; }

    }
}
