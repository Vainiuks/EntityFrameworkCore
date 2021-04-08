using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    public class WorkerController : Controller
    {
      
        WorkerDB workerdb = new WorkerDB();

        // GET: WorkerController
        public ActionResult Index()
        {

            //   var workers = db.Person.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind] Worker work)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    string res = workerdb.SaveRecord(work);
                    TempData["msg"] = res;
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }



            //   var workers = db.Person.ToList();
            return View();
        }

        // GET: WorkerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WorkerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkerController/Create
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

        // GET: WorkerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WorkerController/Edit/5
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

        // GET: WorkerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WorkerController/Delete/5
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
