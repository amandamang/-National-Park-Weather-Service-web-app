﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Favorites
    {
        public int ParkCount { get; set; }
        public string ParkCode { get; set; }
        public string ParkName { get; set; }
        public string ParkDescription { get; set; }
    }
}