using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class ShipperMap : CoreMap<Shipper>
    {
        public ShipperMap()
        {
            ToTable("dbo.Shippers");
            Property(x => x.ShipperID).IsOptional();
            Property(x => x.CompanyName).IsOptional();
            Property(x => x.Phone).IsOptional();

            HasMany(x => x.Orders)
               .WithRequired(x => x.Shippers)
               .HasForeignKey(x => x.Shippers)
               .WillCascadeOnDelete(false);
        }


    }
}
