using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class OrderDetailMap : CoreMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("dbo.OrderDetails");
            Property(x => x.OrderID).IsOptional();
            Property(x => x.ProductID).IsOptional();
            Property(x => x.UnitPrice).IsOptional();
            Property(x => x.Quantity).IsOptional();
            Property(x => x.Discount).IsOptional();



            HasRequired(x => x.Orders)
              .WithMany(x => x.OrderDetails)
              .HasForeignKey(x => x.OrderID)
              .WillCascadeOnDelete(false);
        }
    }
}
