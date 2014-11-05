using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentitySample.Models;
using UTS_TFS_T4_G2.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace UTS_TFS_T4_G2.Controllers
{
    [Authorize(Roles = "Applicant")]
    public class TravelApplicationsController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public TravelApplicationsController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }


        [Authorize(Roles="Admin")]

            public async Task<ActionResult> All()

           {

               return View(await db.TravelApplications.ToListAsync());

           }
        // GET: TravelApplications
        public ActionResult Index()
        {
            //var currentUser = manager.FindById(ApplicationUser.Id.get());

            return View(db.TravelApplications.ToList());//.Where(TravelApplication => TravelApplication.User.Id == currentUser.Id));
        }

        // GET: TravelApplications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelApplication travelApplication = db.TravelApplications.Find(id);
            if (travelApplication == null)
            {
                return HttpNotFound();
            }
            return View(travelApplication);
        }

        // GET: TravelApplications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TravelApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TravelApplicationID,isStaffMember,firstApplicationThisYear,submitDate,supervisorApproved,totalApproved,dateApproved")] TravelApplication travelApplication)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());

            if (ModelState.IsValid)
            {
                travelApplication.User = currentUser;
                db.TravelApplications.Add(travelApplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(travelApplication);
        }

        // GET: TravelApplications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelApplication travelApplication = db.TravelApplications.Find(id);
            if (travelApplication == null)
            {
                return HttpNotFound();
            }
            return View(travelApplication);
        }

        // POST: TravelApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TravelApplicationID,isStaffMember,firstApplicationThisYear,submitDate,supervisorApproved,totalApproved,dateApproved")] TravelApplication travelApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(travelApplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(travelApplication);
        }

        // GET: TravelApplications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelApplication travelApplication = db.TravelApplications.Find(id);
            if (travelApplication == null)
            {
                return HttpNotFound();
            }
            return View(travelApplication);
        }

        // POST: TravelApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TravelApplication travelApplication = db.TravelApplications.Find(id);
            db.TravelApplications.Remove(travelApplication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
