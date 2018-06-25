//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanMan.WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Client()
        {
            this.tbl_Client_Address = new HashSet<tbl_Client_Address>();
            this.tbl_Loan = new HashSet<tbl_Loan>();
        }
    
        public int ClientId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string IDNumber { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Client_Address> tbl_Client_Address { get; set; }
        public virtual tbl_Client tbl_Client1 { get; set; }
        public virtual tbl_Client tbl_Client2 { get; set; }
        public virtual tbl_Gender tbl_Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Loan> tbl_Loan { get; set; }
    }
}