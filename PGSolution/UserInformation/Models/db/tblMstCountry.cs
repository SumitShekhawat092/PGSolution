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
    
    public partial class tblMstCountry
    {
        public tblMstCountry()
        {
            this.tblMstStates = new HashSet<tblMstState>();
            this.tblUserInfoes = new HashSet<tblUserInfo>();
        }
    
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    
        public virtual ICollection<tblMstState> tblMstStates { get; set; }
        public virtual ICollection<tblUserInfo> tblUserInfoes { get; set; }
    }
}
