using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XRM.Application._0_Interface._00_Sistema;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.MVC.Controllers
{
    public class SISDEPARTAController : Controller
    {
        private readonly iasSISDEPARTA _iasSISDEPARTA;

        public SISDEPARTAController(iasSISDEPARTA SISDEPARTA)
        {
            _iasSISDEPARTA = SISDEPARTA;
        }

        // GET: SISDEPARTA
        public ActionResult CSSISDEPARTA()
        {
            var lobjSISDEPARTA = _iasSISDEPARTA.GetAll();
            return View(lobjSISDEPARTA);
        }

        // GET: SISDEPARTA/Details/5
        public ActionResult DTSISDEPARTA(int id)
        {
            var lintSISDEPARTA = _iasSISDEPARTA.GetById(id);
            return View(lintSISDEPARTA);
        }

        // GET: SISDEPARTA/Create
        public ActionResult CRSISDEPARTA()
        {
            return View();
        }

        // POST: SISDEPARTA/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CRSISDEPARTA(vmdSISDEPARTA objSISDEPARTA)
        {
            if (ModelState.IsValid)
            {
                _iasSISDEPARTA.Add(objSISDEPARTA);

                return RedirectToAction("CSSISDEPARTA");
            }

            return View(objSISDEPARTA);
        }

        // GET: SISDEPARTA/Edit/5
        public ActionResult EDSISDEPARTA(int id)
        {
            var lintSISDEPARTA = _iasSISDEPARTA.GetById(id);
            return View(lintSISDEPARTA);
        }

        // POST: SISDEPARTA/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EDSISDEPARTA(vmdSISDEPARTA objSISDEPARTA)
        {
            if (ModelState.IsValid)
            {
                _iasSISDEPARTA.Update(objSISDEPARTA);

                return RedirectToAction("CSSISDEPARTA");
            }

            return View(_iasSISDEPARTA);
        }

        // GET: SISDEPARTA/Delete/5
        public ActionResult DLSISDEPARTA(int id)
        {
            var lintSISDEPARTA = _iasSISDEPARTA.GetById(id);
            return View(lintSISDEPARTA);
        }

        // POST: SISDEPARTA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var lintSISDEPARTA = _iasSISDEPARTA.GetById(id);
            _iasSISDEPARTA.Remove(lintSISDEPARTA);

            return RedirectToAction("CSSISDEPARTA");
        }
    }
}
