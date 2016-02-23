namespace App.Web.Areas.Administration.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using Data;
    using Data.Models;
    using Web.Controllers;

    public class UsersController : BaseController
    {
        private AppDbContext db = new AppDbContext();

        // GET: Administration/Users
        public ActionResult Index()
        {
            return this.View(this.db.Users.ToList());
        }

        // GET: Administration/Users/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = this.db.Users.Find(id);
            if (user == null)
            {
                return this.HttpNotFound();
            }

            return this.View(user);
        }

        // GET: Administration/Users/Create
        public ActionResult Create()
        {
            return this.View();
        }

        // POST: Administration/Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName")] User user)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Users.Add(user);
                this.db.SaveChanges();
                return this.RedirectToAction("Index");
            }

            return this.View(user);
        }

        // GET: Administration/Users/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = this.db.Users.Find(id);
            if (user == null)
            {
                return this.HttpNotFound();
            }

            return this.View(user);
        }

        // POST: Administration/Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName")] User user)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Entry(user).State = EntityState.Modified;
                this.db.SaveChanges();
                return this.RedirectToAction("Index");
            }

            return this.View(user);
        }

        // GET: Administration/Users/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = this.db.Users.Find(id);
            if (user == null)
            {
                return this.HttpNotFound();
            }

            return this.View(user);
        }

        // POST: Administration/Users/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            User user = this.db.Users.Find(id);
            this.db.Users.Remove(user);
            this.db.SaveChanges();
            return this.RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
