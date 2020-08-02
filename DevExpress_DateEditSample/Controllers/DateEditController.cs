using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress_DateEditSample.Controllers
{
    public class DateEditController : Controller
    {
        // GET: DateEdit
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index ([ModelBinder(typeof(DevExpressEditorsBinder))] DateTime dvDE)
        {
            var date = dvDE.Date;
            var time = dvDE.TimeOfDay;

            return View();
        }
    }
}