using System;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using DLG.Account.Contract;
using DLG.Framework.Web;
using DLG.Framework.Contract;
using DLG.Core.Log;
using DLG.Crm.Contract;
using DLG.HR.Contract;

namespace DLG.Web
{
    public abstract class ControllerBase : DLG.Framework.Web.ControllerBase
    {
        public virtual IAccountService AccountService
        {
            get
            {
                return ServiceContext.Current.AccountService;
            }
        } 

        public virtual ICrmService CrmService
        {
            get
            {
                return ServiceContext.Current.CrmService;
            }
        }

        public virtual IHRService HRService
        {
            get
            {
                return ServiceContext.Current.HRService;
            }
        }

        protected override void LogException(Exception exception, 
            WebExceptionContext exceptionContext = null)
        {
            base.LogException(exception);

            var message = new
            {
                exception = exception.Message,
                exceptionContext = exceptionContext,
            };

            Log4NetHelper.Error(LoggerType.WebExceptionLog, message, exception);
        }

        public IDictionary<string, object> CurrentActionParameters { get; set; }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}
