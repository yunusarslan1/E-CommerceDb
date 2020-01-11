using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Model.ORM.Entity.Concrete
{
    public class Order : BaseEntity
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public int ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }


        public virtual List<OrderDetail> OrderDetails { get; set; }

        public virtual List<Employeee> Employees { get; set; }
        public virtual Shipper Shippers { get; set; }
        public virtual Customer Customers { get; set; }


    }
}
