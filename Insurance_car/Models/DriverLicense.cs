//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DriverLicense
    {
        public int id { get; set; }
        public Nullable<int> PersonId { get; set; }
        public Nullable<int> ExperienceYear { get; set; }
        public Nullable<System.DateTime> GivenTime { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string TypeLicense { get; set; }
    }
}
