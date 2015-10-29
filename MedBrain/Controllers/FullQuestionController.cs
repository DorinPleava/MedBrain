using MedBrain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MedBrain.Controllers
{
    public class FullQuestionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: FullQuestion
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuestionAnswers/Create
        public ActionResult Create()
        {
            ViewBag.QuestionAnswerId = new SelectList(db.Questions, "QuestionId", "QuestionText");
            ViewBag.QuestionId = new SelectList(db.QuestionAnswers, "QuestionAnswerId", "QuestionAnswerId");
            return View();
        }

        // POST: QuestionAnswers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FullQuestionId,Question,QuestionAnswer")] FullQuestion fullQuestion)
        {
            if (ModelState.IsValid)
            {
                //Question.User will be completed when the user gets this question
              //  fullQuestion.Question.Users.Add(Membership.GetUser());//(MedBrain.Models.User)Membership.GetUser().us;

                //set default values for DateTime objects


                db.Questions.Add(fullQuestion.Question);
                db.QuestionAnswers.Add(fullQuestion.QuestionAnswer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.QuestionAnswerId = new SelectList(db.Questions, "QuestionId", "QuestionText", fullQuestion.QuestionAnswer.QuestionAnswerId);
            ViewBag.QuestionId = new SelectList(db.QuestionAnswers, "QuestionAnswerId", "QuestionAnswerId", fullQuestion.Question.QuestionId);
            return View(fullQuestion);
        }
    }
}