//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciKayit
{
    using System;
    using System.Collections.Generic;
    
    public partial class Devamsizlik
    {
        public int DevamId { get; set; }
        public Nullable<System.DateTime> Gun { get; set; }
        public string Durumu { get; set; }
        public Nullable<int> OgrenciId { get; set; }
    
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
