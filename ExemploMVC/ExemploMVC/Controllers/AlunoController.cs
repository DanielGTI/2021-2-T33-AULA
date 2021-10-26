using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploMVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: AlunoController
        public ActionResult Index()
        {
            ViewData["Message"] = "Bem vindo ao semestre de 2021";
            return View();
        }

        // GET: AlunoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlunoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlunoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlunoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlunoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
