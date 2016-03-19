using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DLG.HR.Contract;
using DLG.Account.Contract;
using DLG.Web.Admin.Common;
using DLG.Framework.Utility;

namespace DLG.Web.Admin.Areas.HR.Controllers
{
    [Permission(EnumBusinessPermission.HRManage_Org)]
    public class OrgController : AdminControllerBase
    {
        //
        // GET: /HR/Org/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetOrg()
        {
            var rootBranch = this.HRService.GetOrg();

            return Json(rootBranch, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveOrg()
        {
            try
            {
                int bytelength = Request.ContentLength;
                byte[] inputbytes = Request.BinaryRead(bytelength);
                string message = System.Text.Encoding.UTF8.GetString(inputbytes);
                var branch = JsonConvert.DeserializeObject<Branch>(message);

                this.HRService.SaveOrg(branch);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }

            return Content("保存成功！");
        }
    }
}
