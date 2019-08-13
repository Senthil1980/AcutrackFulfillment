using AcutrackFulfillment.Core;
using AcutrackFulfillment.Core;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.Acutrack.Fulfillment.WebAPI.Filters
{
    public class PermissionAttribute : ActionFilterAttribute
    {
        private readonly Permission _permissionEnum;
        private readonly String _resource;

        public PermissionAttribute(Permission permissionEnum, String resource)
        {
            this._permissionEnum = permissionEnum;
            this._resource = resource;
        }
        public override async Task OnActionExecutionAsync(ActionExecutingContext context,  ActionExecutionDelegate next)
        {
            // Do something before the action executes.
            var UserName = context.HttpContext.User.Identity.Name;
            // next() calls the action method.
            var resultContext = await next();
            var exec = "true";
            // resultContext.Result is set.
            // Do something after the action executes.
        }

    }
}
