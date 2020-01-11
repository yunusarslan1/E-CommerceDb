using E_CommerceDb.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Model.ORM.Entity.Concrete
{
    public class BaseEntity : ICore
    {
        public int ID { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status status { get; set; }
    }
}
