//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContractToEntry
    {
        public int ID { get; set; }
        public Nullable<int> LogID { get; set; }
        public int ContractID { get; set; }
        public int EntryID { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual Entry Entry { get; set; }
        public virtual Log Log { get; set; }
    }
}