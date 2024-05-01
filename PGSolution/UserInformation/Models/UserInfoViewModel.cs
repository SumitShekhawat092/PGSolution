using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInformation.Models
{
    public class UserInfoViewModel // Validation
    {
        // Get from Property
        // Value Set to Property
        public int UserId { get; set;}

        [Required]
        [Display(Name ="User Name")]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "User Mobile")]
        [MaxLength(10)]
        public string Mobile { get; set; }

        public int CountryId { get; set; }
        public List<SelectListItem> CountryList { get; set; }

        public int StateId { get; set; }
        public List<SelectListItem> StateList { get; set; }

        public int CityId { get; set; }
        public List<SelectListItem> CityList { get; set; }

        [MaxLength(6)]
        [Range(000001,999999)]
        public string Pincode { get; set; }

    }
}