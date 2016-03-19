using DLG.Framework.Utility;
using DLG.Framework.Web;
using DLG.Web.Admin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLG.Web.Admin.Areas.Account.Controllers
{
    public class CommonController : AdminControllerBase
    {
        [AuthorizeIgnore]
        public virtual ActionResult VerifyImage()
        {
            var validateCodeType = new ValidateCode_Style10();
            string code = "6666";
            byte[] bytes = validateCodeType.CreateImage(out code);
            this.CookieContext.VerifyCodeGuid = VerifyCodeHelper.SaveVerifyCode(code);

            return File(bytes, @"image/jpeg");
        }

        

    }
}
