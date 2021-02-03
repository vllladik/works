using Planer_AspNet.Entities;
using Planer_AspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planer_AspNet.Controllers
{
    public class PlanController : Controller
    {
        PlanContext _context = new PlanContext();
        public ActionResult ListPlans()
        {
            IEnumerable<PlanViewModel> models = _context.Plans.Select(m => new PlanViewModel()
            {
                Id = m.Id,
                Date = m.Date,
                Description = m.Description,
                Img = m.Img,
                IsPriority = m.IsPriority,
                Title = m.Title
            }) ;
            return View(models);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Plan model)
        {
            Plan plan = new Plan
            {
                Title = model.Title,
                Description = model.Description,
                Date = model.Date,
                Img = model.Img,
                IsPriority = false
            };
            _context.Plans.Add(plan);
            _context.SaveChanges();
            return RedirectToAction("ListPlans");
        }

        public ActionResult Delete(int id)
        {
            Plan p = new Plan { Id = id };
            _context.Entry(p).State = EntityState.Deleted;
            _context.SaveChanges();

            return RedirectToAction("ListPlans");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Plan plan = _context.Plans.Find(id);
            PlanViewModel model = new PlanViewModel()
            {

                Id = plan.Id,
                Title = plan.Title,
                Description = plan.Description,
                Date = plan.Date,
                Img = plan.Img,
                IsPriority = false
            };
            return View(model);


        }
        [HttpPost]
        public ActionResult Edit(PlanViewModel model)
        {

            Plan plan = _context.Plans.Find(model.Id);
            plan.Id = model.Id;
            plan.Title = model.Title;
            plan.Description = model.Description;
            plan.Date = model.Date;
            plan.Img = model.Img;
            plan.IsPriority = false;
            _context.SaveChanges();
            return RedirectToAction("ListPlans");
        }






        [HttpPost]
        public ActionResult Find(string FT)
        {

            IEnumerable<PlanViewModel> model = _context.Plans.Select(m => new PlanViewModel()
            {
                Id = m.Id,
                Date = m.Date,
                Description = m.Description,
                Img = m.Img,
                IsPriority = m.IsPriority,
                Title = m.Title
            }).Where(m => m.Title.Contains(FT) == true);



            return View("ListPlans", model);
        }



        public ActionResult Calendar(DateTime date)
        {

          
            var model = _context.Plans.Where(x => x.Date == date).Select(n => new PlanViewModel
            {
                Date = n.Date,
                Description = n.Description,
                Id = n.Id,
                Img = n.Img,
                IsPriority = n.IsPriority,

                Title = n.Title
            });
            return View(model);
        }
    }
}

















