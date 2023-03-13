using System.Web.Mvc;
using XRM.Application._0_Interface._00_Sistema;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.MVC.Controllers
{
    public class SISMODULOXController : Controller
    {
        private readonly iasSISMODULOX _iasSISMODULOX;

        public SISMODULOXController(iasSISMODULOX SISMODULOX)
        {
            _iasSISMODULOX = SISMODULOX;
        }

        // GET: SISMODULOX
        public ActionResult CSSISMODULOX()
        {
            var lobjSISMODULOX = _iasSISMODULOX.GetAll();
            return View(lobjSISMODULOX);
        }

        // GET: SISMODULOX/Details/5
        public ActionResult DTSISMODULOX(int id)
        {
            var lintSISMODULOX = _iasSISMODULOX.GetById(id);
            return View(lintSISMODULOX);
        }

        // GET: SISMODULOX/Create
        public ActionResult CRSISMODULOX()
        {
            return View();
        }

        // POST: SISMODULOX/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CRSISMODULOX(vmdSISMODULOX objSISMODULOX)
        {
            if (ModelState.IsValid)
            {
                _iasSISMODULOX.Add(objSISMODULOX);

                return RedirectToAction("CSSISMODULOX");
            }

            return View(objSISMODULOX);
        }

        // GET: SISMODULOX/Edit/5
        public ActionResult EDSISMODULOX(int id)
        {
            var lintSISMODULOX = _iasSISMODULOX.GetById(id);
            return View(lintSISMODULOX);
        }

        // POST: SISMODULOX/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EDSISMODULOX(vmdSISMODULOX objSISMODULOX)
        {
            if (ModelState.IsValid)
            {
                _iasSISMODULOX.Update(objSISMODULOX);

                return RedirectToAction("CSSISMODULOX");
            }

            return View(_iasSISMODULOX);
        }

        // GET: SISMODULOX/Delete/5
        public ActionResult DLSISMODULOX(int id)
        {
            var lintSISMODULOX = _iasSISMODULOX.GetById(id);
            return View(lintSISMODULOX);
        }

        // POST: SISMODULOX/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var lintSISMODULOX = _iasSISMODULOX.GetById(id);
            _iasSISMODULOX.Remove(lintSISMODULOX);

            return RedirectToAction("CSSISMODULOX");
        }
    }
}
