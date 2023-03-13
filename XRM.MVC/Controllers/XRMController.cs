using System;
using System.Web.Mvc;

namespace XRM.MVC.Controllers
{
    public class XRMController : Controller
    {
        #region Parametros

        private const string mstrURL = "~/Home/Index";

        #endregion Parametros

        // GET: XRM
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Redirecionar()
        {
            return Redirect(Redirecionar("N"));
        }

        public ActionResult RedirecionarMenu()
        {
            return Redirect(Redirecionar("N"));
        }

        private string Redirecionar(string vstrTempData)
        {
            string lstrURL = string.Empty;
            string lstrModulo = string.Empty;
            string lstrArea = string.Empty;
            string lstrController = string.Empty;
            string lstrView = string.Empty;

            try
            {
                if (vstrTempData == "S")
                {
                    TempData.Clear();
                }

                foreach (string lstrParam in Request.QueryString.AllKeys)
                {
                    if (lstrParam != null)
                    {
                        switch (lstrParam.Trim().ToUpper())
                        {
                            case "MODULO":
                                lstrModulo = "/" + Request.QueryString[lstrParam].Trim();
                                break;
                            case "AREA":
                                lstrArea = "/" + Request.QueryString[lstrParam].Trim();
                                break;
                            case "CONTROLLER":
                                lstrController = "/" + Request.QueryString[lstrParam].Trim();
                                break;
                            case "ACTION":
                                lstrView = "/" + Request.QueryString[lstrParam].Trim();
                                break;
                            default:
                                TempData[lstrParam] = Request.QueryString[lstrParam];
                                break;
                        }
                    }
                }

                lstrURL = "~" + lstrModulo + lstrArea + lstrController + lstrView ;

            }
            catch (Exception)
            {
                lstrURL = mstrURL;
            }
            return lstrURL;
        }
    }
}