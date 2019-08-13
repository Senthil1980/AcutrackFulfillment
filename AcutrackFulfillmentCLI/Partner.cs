//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.Acutrack.Fulfillment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            this.Partner_Company = new HashSet<Partner_Company>();
            this.Warehouses = new HashSet<Warehouse>();
        }
    
        public int id { get; set; }
        public Nullable<double> Commission { get; set; }
        public int Branding_id { get; set; }
        public string Logo_path { get; set; }
        public string Subdomain_Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public bool Enabled { get; set; }
    
        public virtual Branding Branding { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partner_Company> Partner_Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}