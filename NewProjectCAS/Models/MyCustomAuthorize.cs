using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace NewProjectCAS
{
    public class MyCustomAuthorize : Attribute, IAuthorizationFilter
    {
        public string Roles { get; set; }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                if (!context.HttpContext.User.IsInRole(Roles))
                {
                    context.Result = new RedirectToActionResult("Unauthorized", "Error", new { area = "" });
                }
            }
            else
            {
                context.Result = new RedirectToActionResult("Login", "Home", new { area = "" });
            }
            
            
        }
    }
}