using Microsoft.AspNetCore.Mvc;
using Nekhala.Data;
using Nekhala.Models;

namespace Nekhala.Controllers
{
    public class SupplyDisbursementController : Controller
    {
        private readonly AppDbContext _db;

        public SupplyDisbursementController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.supplyDisbursements.ToList();
            return View(data);
        }

        // == CREATE ==
        // 1) GET
        public IActionResult Create()
        {
            return View();
        }
        // 2) POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SupplyDisbursement obj)
        {
            // Some Validation
            // -- code here

            if (ModelState.IsValid)
            {
                _db.supplyDisbursements.Add(obj);
                _db.SaveChanges();
                // Flash Message
                TempData["success"] = "Data Saved Successfully!!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // == UPDATE ==
        // 1) GET
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            // Trying To Find Data
            var data = _db.supplyDisbursements.Find(id);
            if (data == null)
                return NotFound();

            return View(data);
        }
        // 2) POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SupplyDisbursement obj)
        {
            // Some Validation
            // -- code here

            if (ModelState.IsValid)
            {
                _db.supplyDisbursements.Update(obj);
                _db.SaveChanges();
                // Flash Message
                TempData["success"] = "Data Updated Successfully!!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // == DELETE ==
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            // Trying To Find Data
            var data = _db.supplyDisbursements.Find(id);
            if (data == null)
                return NotFound();

            _db.supplyDisbursements.Remove(data);
            _db.SaveChanges();
            // Flash Message
            TempData["success"] = "Data Deleted Successfully!!";

            return RedirectToAction("Index");
        }

        // Item Details
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            // Trying To Find Data
            var data = _db.supplyDisbursements.Find(id);
            if (data == null)
                return NotFound();

            return View(data);
        }
    }
}
