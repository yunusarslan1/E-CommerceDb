using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class SupplierMap : CoreMap<Supplier>
    {
        public SupplierMap()
        {

            ToTable("dbo.Suppliers");
            Property(x => x.SupplierID).IsOptional();
            Property(x => x.CompanyName).IsOptional();
            Property(x => x.ContactName).IsOptional();
            Property(x => x.ContactTitle).IsOptional();
            Property(x => x.Address).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.Fax).IsOptional();
            Property(x => x.HomePage).IsOptional();
            Property(x => x.Phone).IsOptional();



            HasKey(x => new
            {
                x.Products

            });
        }
    }
}
