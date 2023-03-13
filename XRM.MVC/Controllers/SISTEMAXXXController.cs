using System.Web.Mvc;
using XRM.Application._0_Interface._00_Sistema;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.MVC.Controllers
{
    public class SISTEMAXXXController : Controller
    {
        private readonly iasSISTEMAXXX _iasSISTEMAXXX;
        private readonly iasSISMODULOX _iasSISMODULOX;

        public SISTEMAXXXController(iasSISTEMAXXX SISTEMAXXX, iasSISMODULOX SISMODULOX)
        {
            _iasSISTEMAXXX = SISTEMAXXX;
            _iasSISMODULOX = SISMODULOX;
        }

        // GET: SISTEMAXXX
        public ActionResult CSSISTEMAXXX()
        {
            var lobjSISTEMAXXX = _iasSISTEMAXXX.GetAll();
            return View(lobjSISTEMAXXX);
        }

        // GET: SISTEMAXXX/Details/5
        public ActionResult DTSISTEMAXXX(int id)
        {
            var lintSISTEMAXXX = _iasSISTEMAXXX.GetById(id);
            return View(lintSISTEMAXXX);
        }

        // GET: SISTEMAXXX/Create
        public ActionResult CRSISTEMAXXX()
        {
            ViewBag.TBSISMODULOX_NS = new SelectList(_iasSISMODULOX.GetAll(), "TBSISMODULOX_NS", "TBSISMODULOX_NM");
            return View();
        }

        // POST: SISTEMAXXX/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CRSISTEMAXXX(vmdSISTEMAXXX objSISTEMAXXX)
        {
            if (ModelState.IsValid)
            {
                _iasSISTEMAXXX.Add(objSISTEMAXXX);

                return RedirectToAction("CSSISTEMAXXX");
            }

            ViewBag.TBSISMODULOX_NS = new SelectList(_iasSISMODULOX.GetAll(), "TBSISMODULOX_NS", "TBSISMODULOX_NM", objSISTEMAXXX.TBSISMODULOX_NS);

            return View(objSISTEMAXXX);
        }

        // GET: SISTEMAXXX/Edit/5
        public ActionResult EDSISTEMAXXX(int id, vmdSISTEMAXXX objSISTEMAXXX)
        {
            var lintSISTEMAXXX = _iasSISTEMAXXX.GetById(id);

            ViewBag.TBSISMODULOX_NS = new SelectList(_iasSISMODULOX.GetAll(), "TBSISMODULOX_NS", "TBSISMODULOX_NM", objSISTEMAXXX.TBSISMODULOX_NS);
            return View(lintSISTEMAXXX);
        }

        // POST: SISTEMAXXX/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EDSISTEMAXXX(vmdSISTEMAXXX objSISTEMAXXX)
        {
            if (ModelState.IsValid)
            {
                _iasSISTEMAXXX.Update(objSISTEMAXXX);

                return RedirectToAction("CSSISTEMAXXX");
            }

            ViewBag.TBSISMODULOX_NS = new SelectList(_iasSISMODULOX.GetAll(), "TBSISMODULOX_NS", "TBSISMODULOX_NM", objSISTEMAXXX.TBSISMODULOX_NS);
            return View(_iasSISTEMAXXX);
        }

        // GET: SISTEMAXXX/Delete/5
        public ActionResult DLSISTEMAXXX(int id)
        {
            var lintSISTEMAXXX = _iasSISTEMAXXX.GetById(id);
            return View(lintSISTEMAXXX);
        }

        // POST: SISTEMAXXX/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var lintSISTEMAXXX = _iasSISTEMAXXX.GetById(id);
            _iasSISTEMAXXX.Remove(lintSISTEMAXXX);

            return RedirectToAction("CSSISTEMAXXX");
        }
    }
}
