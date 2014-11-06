using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentitySample.Models;
using UTS_TFS_T4_G2.Models;

namespace UTS_TFS_T4_G2.Controllers
{
    [Authorize]
    public class TravelApplicationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TravelApplications
        public async Task<ActionResult> Index()
        {
            return View(await db.TravelApplications.ToListAsync());
        }

        // GET: TravelApplications/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelApplication travelApplication = await db.TravelApplications.FindAsync(id);
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
        public async Task<ActionResult> Create([Bind(Include = "TravelApplicationID,isStaffMember,firstApplicationThisYear,submitDate,supervisorApproved,totalApproved,dateApproved,travelDetails,fundingDetails")] TravelApplication travelApplication)
        {
            if (ModelState.IsValid)   //--checks if application is filled out properly
            {
                db.TravelApplications.Add(travelApplication);       //--add to database
                await db.SaveChangesAsync();                        //--save database changes
                return RedirectToAction("Index");                   //--return to index view
            }

            return View(travelApplication);
        }

        // GET: TravelApplications/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)     //--no application to edit
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelApplication travelApplication = await db.TravelApplications.FindAsync(id);    //--retrieve application from database
            if (travelApplication == null)      //--if no application found, 
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
        public async Task<ActionResult> Edit([Bind(Include = "TravelApplicationID,isStaffMember,firstApplicationThisYear,submitDate,supervisorApproved,totalApproved,dateApproved,travelDetails,fundingDetails")] TravelApplication travelApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(travelApplication).State = EntityState.Modified;   //--modify database
                await db.SaveChangesAsync();                                //--save changes
                return RedirectToAction("Index");                           //--return to index
            }
            return View(travelApplication);                             //--otherwise highlight missing fields and stay in edit view
        }

        // GET: TravelApplications/Delete/5
        public async Task<ActionResult> Delete(int? id)             //--disabled for iteration 1
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelApplication travelApplication = await db.TravelApplications.FindAsync(id);
            if (travelApplication == null)
            {
                return HttpNotFound();
            }
            return View(travelApplication);
        }

        // POST: TravelApplications/Delete/5            //--disabled for iteration 1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)         
        {
            TravelApplication travelApplication = await db.TravelApplications.FindAsync(id);
            db.TravelApplications.Remove(travelApplication);
            await db.SaveChangesAsync();
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
