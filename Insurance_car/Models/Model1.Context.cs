﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insurance_car.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sugurtaEntities : DbContext
    {
        public sugurtaEntities()
            : base("name=sugurtaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<DriverLicense> DriverLicense { get; set; }
        public virtual DbSet<OnlineSugurta> OnlineSugurta { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
