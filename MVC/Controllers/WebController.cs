using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Services;

namespace MVC.Controllers
{
   
    public class WebController : Controller
    {
        MyService MyService= new MyService();
        // GET: Web
        public ActionResult Index(int id)
        {
            var all=MyService.first(id);
            return Ok(all);
        }

        // GET: Web/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Web/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Web/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Web/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Web/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Web/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Web/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}