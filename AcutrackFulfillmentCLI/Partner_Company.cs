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
    
    public partial class Partner_Company
    {
        public int id { get; set; }
        public int Partner_Id { get; set; }
        public int Company_Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Partner Partner { get; set; }
    }
}
