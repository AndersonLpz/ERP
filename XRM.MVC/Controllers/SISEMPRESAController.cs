using System.Web.Mvc;
using XRM.Application._0_Interface._00_Sistema;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.MVC.Controllers
{
    public class SISEMPRESAController : Controller
    {
        private readonly iasSISEMPRESA _iasSISEMPRESA;

        public SISEMPRESAController(iasSISEMPRESA SISEMPRESA)
        {
            _iasSISEMPRESA = SISEMPRESA;
        }

        // GET: SISEMPRESA
        public ActionResult CSSISEMPRESA()
        {
            var lobjSISEMPRESA = _iasSISEMPRESA.GetAll();
            return View(lobjSISEMPRESA);
        }

        // GET: SISEMPRESA/Details/5
        public ActionResult DTSISEMPRESA(int id)
        {
            var lintSISEMPRESA = _iasSISEMPRESA.GetById(id);
            return View(lintSISEMPRESA);
        }

        // GET: SISEMPRESA/Create
        public ActionResult CRSISEMPRESA()
        {
            return View();
        }

        // POST: SISEMPRESA/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CRSISEMPRESA(vmdSISEMPRESA objSISEMPRESA)
        {
            if (ModelState.IsValid)
            {
                _iasSISEMPRESA.Add(objSISEMPRESA);

                //return RedirectToAction("CSSISEMPRESA");

            }

            return Json(new { TBSISEMPRESA_NS = objSISEMPRESA.TBSISEMPRESA_NS }, JsonRequestBehavior.AllowGet); //      View(objSISEMPRESA);
        }

        // GET: SISEMPRESA/Edit/5
        public ActionResult EDSISEMPRESA(int id)
        {
            var lintSISEMPRESA = _iasSISEMPRESA.GetById(id);
            return View(lintSISEMPRESA);
        }

        // POST: SISEMPRESA/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EDSISEMPRESA(vmdSISEMPRESA objSISEMPRESA)
        {
            if (ModelState.IsValid)
            {
                _iasSISEMPRESA.Update(objSISEMPRESA);

                return RedirectToAction("CSSISEMPRESA");
            }

            return View(_iasSISEMPRESA);
        }

        // GET: SISEMPRESA/Delete/5
        public ActionResult DLSISEMPRESA(int id)
        {
            var lintSISEMPRESA = _iasSISEMPRESA.GetById(id);
            return View(lintSISEMPRESA);
        }

        // POST: SISEMPRESA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var lintSISEMPRESA = _iasSISEMPRESA.GetById(id);
            _iasSISEMPRESA.Remove(lintSISEMPRESA);

            return RedirectToAction("CSSISEMPRESA");
        }
    }
}
