﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiAssgn2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class zensarDbEntities : DbContext
    {
        public zensarDbEntities()
            : base("name=zensarDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
    
        public virtual ObjectResult<getEmpsalary_Result> getEmpsalary(Nullable<int> eid)
        {
            var eidParameter = eid.HasValue ?
                new ObjectParameter("eid", eid) :
                new ObjectParameter("eid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmpsalary_Result>("getEmpsalary", eidParameter);
        }
    }
}
