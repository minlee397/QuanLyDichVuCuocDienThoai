//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDienThoaiEntity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTRACT
    {
        public string ID_CONTRACT { get; set; }
        public string ID_SIM { get; set; }
        public Nullable<System.DateTime> DATEREGISTER { get; set; }
        public Nullable<int> FEE { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        public virtual SIM SIM { get; set; }
    }
}
