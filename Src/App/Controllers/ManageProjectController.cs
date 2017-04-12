﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ttu.Presentation;

namespace App.Controllers
{
    public class ManageProjectController : AbstractController
    {
        // GET: ManageProject
        public ActionResult Index()
        {
            IPresenterFactory presenterFactory = ValidatePresenterFactory();
            ManageProjectPresenter presenter = presenterFactory.CreateManageProjectPresenter();
            return View(presenter.GetProjects());
        }

        // GET: ManageProject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageProject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageProject/Create
        [HttpPost]
        public ActionResult Create(ProjectModel projectModel)
        {
            try
            {
                IPresenterFactory presenterFactory = ValidatePresenterFactory();
                ManageProjectPresenter presenter = presenterFactory.CreateManageProjectPresenter();
                presenter.AddProject(projectModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageProject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageProject/Edit/5
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

        // GET: ManageProject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageProject/Delete/5
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