using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DLG.HR.Contract;
using DLG.Account.Contract;
using DLG.Web.Admin.Common;
using DLG.Framework.Utility;

namespace DLG.Web.Admin.Areas.HR.Controllers
{
    [Permission(EnumBusinessPermission.HRManage_Branch)]
    public class BranchController : AdminControllerBase
    {
        //
        // GET: /HR/Branch/

        public ActionResult Index(BranchRequest request)
        {
            var result = this.HRService.GetBranchList(request);
            return View(result);
        }

        //
        // GET: /HR/Branch/Create

        public ActionResult Create()
        {
            var model = new Branch();
            return View("Edit", model);
        }

        //
        // POST: /HR/Branch/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var model = new Branch();
            this.TryUpdateModel<Branch>(model);

            this.HRService.SaveBranch(model);

            return this.RefreshParent();
        }

        //
        // GET: /HR/Branch/Edit/5

        public ActionResult Edit(int id)
        {
            var model = this.HRService.GetBranch(id);
            return View(model);
        }

        //
        // POST: /HR/Branch/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var model = this.HRService.GetBranch(id);
            this.TryUpdateModel<Branch>(model);

            this.HRService.SaveBranch(model);

            return this.RefreshParent();
        }

        // POST: /HR/Branch/Delete/5

        [HttpPost]
        public ActionResult Delete(List<int> ids)
        {
            this.HRService.DeleteBranch(ids);
            return RedirectToAction("Index");
        }
    }
}
