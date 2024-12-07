using CrowdFundingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrowdFundingApp.Controllers
{
    public class ContributionController : Controller
    {
        private CrowdFundingDbContext dbcontext;

        public ContributionController(CrowdFundingDbContext context)
        {
            dbcontext = context;
        }

        // GET: ContributionController
        public ActionResult Index()
        {
            List<Contribution> contributions = dbcontext.Contributions.ToList();
            return View(contributions);
        }

        // GET: ContributionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContributionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContributionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contribution contribution)
        {
            try
            {
                dbcontext.Contributions.Add(contribution);
                dbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(contribution);
            }
        }

        // GET: ContributionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContributionController/Edit/5
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

        // GET: ContributionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContributionController/Delete/5
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
