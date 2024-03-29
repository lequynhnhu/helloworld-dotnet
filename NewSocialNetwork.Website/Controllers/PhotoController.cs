﻿using System.Web.Mvc;
using NewSocialNetwork.Repositories;
using NewSocialNetwork.Website.Models;

namespace NewSocialNetwork.Website.Controllers
{
    public class PhotoController : AbstractController
    {
        public IPhotoRepository photoRepo { get; set; }

        public PhotoController()
        {
            ViewBag.PageTitle = "NSN: Photo";
        }

        //
        // GET: /Photo/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InsertSave()
        {
            return RedirectToAction("Insert");
        }

        [HttpPost]
        public ActionResult InsertSave(InsertPhotoModel model)
        {
            try
            {
                string test = model.Test;
                if (test.Equals("abc"))
                {
                    ViewBag.Message = "Insert Successfully";
                }
                else
                {
                    ViewBag.Message = "Insert Failed";
                }
            }
            catch
            {
                ViewBag.Message = "Insert Error";
            }
            return View("Insert");
        }
    }
}
