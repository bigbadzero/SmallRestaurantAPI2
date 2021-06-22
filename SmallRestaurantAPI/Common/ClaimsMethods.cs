using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Common
{
    public class ClaimsMethods: ControllerBase
    {
        private string GetCurrentUserID()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var idClaim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = idClaim.Value;

            return userId;
        }
    }
}
