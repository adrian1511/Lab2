using KoreanBeauty.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Attributes
{
    public class AdminAttribute : AuthorizeAttribute
    {
        private BusinessLogic Bl { get; }


        public AdminAttribute()
        {
            Bl = new BusinessLogic();
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Request.IsAuthenticated && Role(httpContext);
        }

        private bool Role(HttpContextBase httpContext)
        {
            var user = Bl.UserAPI.GetUser(httpContext.User.Identity.Name);
            return user.Role == "admin";
        }
    }
}