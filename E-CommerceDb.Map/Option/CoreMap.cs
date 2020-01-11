using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class CoreMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public CoreMap()
        {
            Property(x => x.ID).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AddDate).HasColumnName("AddDate").IsOptional();
            Property(x => x.UpdateDate).HasColumnName("UpdateDate").IsOptional();
            Property(x => x.DeleteDate).HasColumnName("DeleteDate").IsOptional();

        }
    }
}
