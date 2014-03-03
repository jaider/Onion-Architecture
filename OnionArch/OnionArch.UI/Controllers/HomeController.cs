using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnionArch.Core.Service;
using OnionArch.Core.Interfaces;
using OnionArch.UI.Helpers;
using OnionArch.UI.ViewModel;

namespace OnionArch.UI.Controllers
{
    public class HomeController : Controller
    {
        ITodoService _todoService;

        public HomeController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var itemList = _todoService.GetAll();
            var mvList = Mapper.MapToHomeViewModel(itemList);
            return View(mvList);
        }

        [HttpPost]
        public ActionResult Index(TodoNewViewModel item)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _todoService.Create(item.Note);
                }
                catch (Exception)
                {
                    //Catch Error on create
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult MarkAsCompleted(Guid id)
        {
            try
            {
                _todoService.MarkAsCompleted(id);
            }
            catch (Exception)
            {
                //Catch Error on update, such as timeout
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            try
            {
                _todoService.Delete(id);
            }
            catch (Exception)
            {
                //Catch Error on delete, such as no exist
            }

            return RedirectToAction("Index");
        }

    }
}
