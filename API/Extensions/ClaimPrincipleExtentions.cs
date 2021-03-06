using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class ClaimPrincipleExtentions
    {
        public static string getUserName(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }
        public static int getUserId(this ClaimsPrincipal user)
        {
            var del = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}