using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Todo.Web.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogActionInfo(filterContext);
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogActionInfo(filterContext);
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogActionInfo(filterContext);
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogActionInfo(filterContext);
            base.OnResultExecuted(filterContext);
        }

        private void LogActionInfo(ControllerContext controllerContext)
        {

            var controller = controllerContext.RouteData.Values["controller"];
            var action = controllerContext.RouteData.Values["action"];

            Debug.WriteLine($"{nameof(OnActionExecuting)} controller: {controller} action: {action}");
        }
    }
}