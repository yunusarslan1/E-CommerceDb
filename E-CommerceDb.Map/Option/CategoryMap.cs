using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class CategoryMap : CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categorys");
            Property(x => x.CategoryID).IsOptional();
            Property(x => x.CategoryName).HasMaxLength(20).HasColumnType("NVarChar").IsRequired();
            Property(x => x.Description).HasMaxLength(55).HasColumnType("NVarChar").IsOptional();
            Property(x => x.Picture).IsOptional();

            HasMany(x => x.Products)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(true);


        }
    }
}
