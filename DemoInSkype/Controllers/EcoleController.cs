using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoInSkype.BLL.Services;
using DemoInSkype.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoInSkype.Controllers
{
    public class EcoleController : Controller
    {
        private readonly IEcoleService _ecoleService;
        public EcoleController(IEcoleService ecoleService)
        {
            _ecoleService = ecoleService;
        }
        // GET: Ecoles
        public ActionResult Index()
        {
            return View(_ecoleService.GetAllEcoles());
        }

        // GET: Ecole/Details/5
        public ActionResult Details(int id)
        {
            return View(_ecoleService.GetEcoleById(id));
        }

        // GET: Ecole/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ecole/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ecole ecole)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                    _ecoleService.Register(ecole);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ecole/Edit/5
        public ActionResult Edit(int id)
        {
            //_ecoleService.GetEcoleById(id)
            return View(_ecoleService.GetEcoleById(id));
        }

        // POST: Ecole/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Ecole ecole)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                    _ecoleService.Update(ecole);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ecole/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_ecoleService.GetEcoleById(id));
        }

        // POST: Ecole/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _ecoleService.DeleteEcole(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}