using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class OrderMap : CoreMap<Order>
    {
        public OrderMap()
        {

            ToTable("dbo.Orders");
            Property(x => x.EmployeeID).IsOptional();
            Property(x => x.OrderID).IsOptional();
            Property(x => x.CustomerID).IsOptional();
            Property(x => x.OrderDate).IsOptional();
            Property(x => x.RequiredDate).IsOptional();
            Property(x => x.ShippedDate).IsOptional();
            Property(x => x.ShipVia).IsOptional();
            Property(x => x.Freight).IsOptional();
            Property(x => x.ShipAddress).IsOptional();
            Property(x => x.ShipCity).IsOptional();
            Property(x => x.ShipName).IsOptional();
            Property(x => x.ShipPostalCode).IsOptional();
            Property(x => x.ShipCountry).IsOptional();
            Property(x => x.ShipRegion).IsOptional();




            HasKey(x => new
            {

                x.Employees

            });

            HasRequired(x => x.Customers)
              .WithMany(x => x.Orders)
              .HasForeignKey(x => x.OrderID)
              .WillCascadeOnDelete(false);



            HasRequired(x => x.Shippers)
              .WithMany(x => x.Orders)
              .HasForeignKey(x => x.OrderID)
              .WillCascadeOnDelete(false);

            HasMany(x => x.OrderDetails)
               .WithRequired(x => x.Orders)
               .HasForeignKey(x => x.OrderID)
               .WillCascadeOnDelete(false);


        }
    }
}
