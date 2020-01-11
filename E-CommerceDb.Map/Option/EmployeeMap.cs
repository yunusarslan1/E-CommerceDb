using E_CommerceDb.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.Map.Option
{
    public class EmployeeMap : CoreMap<Employeee>
    {
        public EmployeeMap()
        {
            ToTable("dbo.Employees");
            Property(x => x.EmployeeID).IsOptional();
            Property(x => x.LastName).IsOptional();
            Property(x => x.FirstName).IsOptional();
            Property(x => x.Title).IsOptional();
            Property(x => x.TitleOfCourtesy).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.BirthDate).IsOptional();
            Property(x => x.HireDate).IsOptional();
            Property(x => x.HomePhone).IsOptional();
            Property(x => x.Extension).IsOptional();
            Property(x => x.Photo).IsOptional();
            Property(x => x.Notes).IsOptional();
            Property(x => x.ReportsTo).IsOptional();


            HasKey(x => new
            {
                x.Orders
            });



        }
    }
}
