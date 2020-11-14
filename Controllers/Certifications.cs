using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeAngularNet.Models;
//using ResumeAngularNet.Models;


namespace ResumeAngularNet.Controllers
{
    public class Certifications : Controller
    {
        private readonly ResumeAngularDBContext _ctx;

        public Certifications(ResumeAngularDBContext ctx)
        {
            _ctx = ctx;
        }   


        //GET: Certifications
        public ActionResult Index()
        {
            var results = _ctx.Certification.ToList();


            return View(results);
        }

        // GET: Certifications/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Certifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Certifications/Create
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

        // GET: Certifications/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Certifications/Edit/5
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

        // GET: Certifications/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Certifications/Delete/5
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
