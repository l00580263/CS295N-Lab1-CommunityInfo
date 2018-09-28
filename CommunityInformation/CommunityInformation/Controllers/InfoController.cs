﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommunityInformation.Controllers
{
    public class InfoController : Controller
    {



        #region Methods
        public ViewResult Info()
        {
            // Info Page
            return View("Info");
        }



        public ViewResult Locations()
        {
            // Locations Page
            return View("Locations");
        }



        public ViewResult People()
        {
            // People Page
            return View("People");
        }
        #endregion
    }
}