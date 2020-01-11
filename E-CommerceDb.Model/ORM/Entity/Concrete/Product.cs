using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Model.ORM.Entity.Concrete
{
    public class Product : BaseEntity
    {

        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discountinued { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int ProductID { get; set; }
        public virtual Product Products { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }



    }
}
