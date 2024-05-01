using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInformation.Models;
using UserInformation.Models.db;

namespace UserInformation.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo // List
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet] // Page Load - 
        public ActionResult Add()
        {
            // Country List
            db_PLEntities db = new db_PLEntities();
            var countryList =  db.tblMstCountries.ToList();

            List<SelectListItem> countryItems = new List<SelectListItem>();
            foreach (var country in countryList)
            {
                countryItems.Add( new SelectListItem() 
                                    {   Text = country.CountryName
                                        , Value = country.CountryId.ToString(),
                                        
                                    } );
            }

            //// State List
            var stateList = db.tblMstStates.ToList();
            List<SelectListItem> stateItems = new List<SelectListItem>();
            foreach (var state in stateList)
            {
                stateItems.Add(new SelectListItem()
                {
                    Text = state.StateName,
                    Value = state.StateId.ToString()
                });
            }

            //// City List
            //var cityList = db.tblMstCities.ToList();

            UserInfoViewModel usermodel = new UserInfoViewModel();
            usermodel.CountryList = countryItems;
            usermodel.StateList = stateItems;
            return View(usermodel);
        }

        [HttpPost] // 
        public ActionResult Add(UserInfoViewModel usermodel)
        {
            if (ModelState.IsValid)
            {
                // data save => database
                //Insert data
                //

            }
            else
            {
                // Fail // Model related Validation
            }
            return View();
        }


    }
}