﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Services
{
    public class GrabCurrentUserIDService
    {
        public string CurrentUserID { get; set; }
        public string CurrentUserEmail { get; set; }
        public bool isUserGuest { get; set; } = false;
        public bool isUserNormal { get; set; } = false;

        public string IdentityUserID { get; set; }



    }
}
