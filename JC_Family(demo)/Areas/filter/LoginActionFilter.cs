using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace JC_Family_demo_.Areas.filter
{
    public class LoginActionFilterAttribute: ActionFilterAttribute
    {
        public const string Url = "~/Account/Error?error=";
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.ActionDescriptor.ActionName != "LoginError")
            {
                var user = filterContext.HttpContext.User.Identity.Name;
                if (user != null)
                {
                    var currentSessionId = filterContext.HttpContext.Session.SessionID;
                    var userSessionId = filterContext.HttpContext.Cache.Get(user);
                    if (userSessionId != null)
                    {
                        if (currentSessionId != userSessionId.ToString())
                        {
                            filterContext.Result = new RedirectResult(Url + "你的帐号已在别处登陆，你被强迫下线!");
                        }
                    }
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}