using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trymvc1.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreMaster _IStoreMaster;
        public StoreController(IStoreMaster IStoreMaster)
        {
            this._IStoreMaster = IStoreMaster;
        }

        // GET: Store
        public ActionResult Index()
        {
            StoreMaster storemaster = _IStoreMaster.Getstore(1);
            return View(storemaster);
        }
    }
}