﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErwinGallo.SocialHUB.Web.Infrastructure.Data.Enums
{
    public enum LoginStatus
    {
        Unverified,
        Active,
        Locked,
        NeedsToChangePassword
    }
}
