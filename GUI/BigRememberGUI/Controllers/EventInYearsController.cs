﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConnectionSampleCode.HandleUtil;

namespace BigRememberGUI.Controllers
{
    public class EventInYearsController : Controller
    {
        private readonly EvenInYearUtil _evenInYearUtil;

        public EventInYearsController()
        {
            _evenInYearUtil = new EvenInYearUtil();
        }

        // GET: EventInYears
        public ActionResult Index()
        {
            return View(_evenInYearUtil.GetEventInYears());
        }

        // GET: EventInYears/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventInYears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventInYears/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventInYears/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventInYears/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventInYears/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventInYears/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
