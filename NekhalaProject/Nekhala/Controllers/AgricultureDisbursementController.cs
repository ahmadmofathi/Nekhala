using Microsoft.AspNetCore.Mvc;
using Nekhala.Data;
using Nekhala.Models;

namespace Nekhala.Controllers
{
    public class AgricultureDisbursementController : Controller
    {
        private readonly AppDbContext _con;

        public AgricultureDisbursementController(AppDbContext con)
        {
            _con = con;
        }
        public IActionResult Index()
        {
            var result = _con.agricultureDisbursements.ToList();
            return View(result);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AgricultureDisbursement model)
        {
            if (ModelState.IsValid)
            {
                _con.agricultureDisbursements.Add(model);
                _con.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(string? id)
        {
            var re = _con.agricultureDisbursements.Find(id);
            return View("Create",re);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AgricultureDisbursement model)
        {
            if (model != null)
            {
                _con.agricultureDisbursements.Update(model);
                _con.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(string? id)
        {
            var re = _con.agricultureDisbursements.Find(id);
            if (re != null)
            {
                _con.agricultureDisbursements.Remove(re);
                _con.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        public IActionResult Details(string? id)
        {
            if (id == null)
                return NotFound();

            var re = _con.agricultureDisbursements.Find(id);

            if (re == null) 
                return NotFound();

            return View(re);
        }

    }
}
