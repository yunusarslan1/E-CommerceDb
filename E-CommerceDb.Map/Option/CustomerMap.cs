using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class CustomerMap : CoreMap<Customer>
    {
        public CustomerMap()
        {
            ToTable("dbo.Customers");
            Property(x => x.CustomerID).IsOptional();
            Property(x => x.CompanyName).IsOptional();
            Property(x => x.ContactName).IsOptional();
            Property(x => x.ContactTitle).IsOptional();
            Property(x => x.Address).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.Phone).IsOptional();
            Property(x => x.Fax).IsOptional();

            HasMany(x => x.Orders)
               .WithRequired(x => x.Customers)
               .HasForeignKey(x => x.CustomerID)
               .WillCascadeOnDelete(false);
        }
    }
}
