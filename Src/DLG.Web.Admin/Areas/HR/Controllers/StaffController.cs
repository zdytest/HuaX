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
    [Permission(EnumBusinessPermission.HRManage_Staff)]
    public class StaffController : AdminControllerBase
    {
        //
        // GET: /HR/Staff/

        public ActionResult Index(StaffRequest request)
        {
            var result = this.HRService.GetStaffList(request);
            return View(result);
        }

        //
        // GET: /HR/Staff/Create

        public ActionResult Create()
        {
            var model = new Staff() { };
            this.RenderMyViewData(model);
            return View("Edit", model);
        }

        //
        // POST: /HR/Staff/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var model = new Staff();
            this.TryUpdateModel<Staff>(model);

            this.HRService.SaveStaff(model);

            return this.RefreshParent();
        }

        //
        // GET: /HR/Staff/Edit/5

        public ActionResult Edit(int id)
        {
            var model = this.HRService.GetStaff(id);
            this.RenderMyViewData(model);
            return View(model);
        }

        //
        // POST: /HR/Staff/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var model = this.HRService.GetStaff(id);
            this.TryUpdateModel<Staff>(model);

            this.HRService.SaveStaff(model);

            return this.RefreshParent();
        }

        // POST: /HR/Staff/Delete/5

        [HttpPost]
        public ActionResult Delete(List<int> ids)
        {
            this.HRService.DeleteStaff(ids);
            return RedirectToAction("Index");
        }

        private void RenderMyViewData(Staff model)
        {
            ViewData.Add("Position", new SelectList(EnumHelper.GetItemValueList<EnumPosition>(), "Key", "Value", model.Position));
            ViewData.Add("Gender", new SelectList(EnumHelper.GetItemValueList<EnumGender>(), "Key", "Value", model.Gender));
        }
    }
}
