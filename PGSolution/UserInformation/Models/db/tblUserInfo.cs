//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserInformation.Models.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUserInfo
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Pincode { get; set; }
    
        public virtual tblMstCity tblMstCity { get; set; }
        public virtual tblMstCountry tblMstCountry { get; set; }
        public virtual tblMstState tblMstState { get; set; }
    }
}