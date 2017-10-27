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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.CategoryOwners = new HashSet<CategoryOwner>();
            this.Entries = new HashSet<Entry>();
            this.UserOwners = new HashSet<UserOwner>();
            this.UserOwners1 = new HashSet<UserOwner>();
        }
    
        public int ID { get; set; }
        public Nullable<int> LogID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string KinkName { get; set; }
        public int KinkRoleID { get; set; }
        public int KTRoleID { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryOwner> CategoryOwners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entries { get; set; }
        public virtual Schema Schema { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserOwner> UserOwners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserOwner> UserOwners1 { get; set; }
        public virtual KinkRole KinkRole { get; set; }
    }
}