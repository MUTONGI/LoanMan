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
    
    public partial class tbl_Client_Address
    {
        public int AddressId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
    
        public virtual tbl_Client tbl_Client { get; set; }
    }
}
