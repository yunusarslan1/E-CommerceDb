using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class ProductMap : CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(x => x.SupplierID).IsOptional();
            Property(x => x.ProductID).IsOptional();
            Property(x => x.UnitPrice).IsOptional();
            Property(x => x.QuantityPerUnit).IsOptional();
            Property(x => x.UnitsInStock).IsOptional();
            Property(x => x.UnitsOnOrder).IsOptional();
            Property(x => x.ReorderLevel).IsOptional();
            Property(x => x.Discountinued).IsOptional();
            Property(x => x.CategoryID).IsOptional();
            Property(x => x.ProductID).IsOptional();



            HasMany(x => x.OrderDetails)
              .WithRequired(x => x.Product)
              .HasForeignKey(x => x.ProductID)
              .WillCascadeOnDelete(false);



            HasRequired(x => x.Category)
             .WithMany(x => x.Products)
             .HasForeignKey(x => x.ProductID)
             .WillCascadeOnDelete(false);
        }
    }
}
