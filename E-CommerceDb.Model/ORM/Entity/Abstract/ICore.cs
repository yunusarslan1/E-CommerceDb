using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Model.ORM.Entity.Abstract
{
    public enum Status
    {
        Active = 0,
        Passive = 1,
        Delete = 2,
        Update = 3


    } 

    public interface ICore
    {
        int ID { get; set; }
        DateTime AddDate { get; set; }

        DateTime? DeleteDate { get; set; }

        DateTime? UpdateDate { get; set; }

        Status status { get; set; }
    }
}
