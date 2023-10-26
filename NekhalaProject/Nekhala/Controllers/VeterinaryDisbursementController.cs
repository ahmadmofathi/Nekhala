using Microsoft.AspNetCore.Mvc;
using Nekhala.Data;
using Nekhala.Models;

namespace Nekhala.Controllers
{
    public class VeterinaryDisbursementController : Controller
    {
        private readonly AppDbContext _db;

        public VeterinaryDisbursementController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.veterinaryDisbursements.ToList();
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
        public IActionResult Create(VeterinaryDisbursement obj)
        {
            // Some Validation
            // -- code here

            if (ModelState.IsValid)
            {
                _db.veterinaryDisbursements.Add(obj);
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
            if(id == null) 
                return NotFound();

            // Trying To Find Data
            var data = _db.veterinaryDisbursements.Find(id);
            if (data == null)
                return NotFound();

            return View(data);
        }
        // 2) POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VeterinaryDisbursement obj)
        {
            // Some Validation
            // -- code here

            if (ModelState.IsValid)
            {
                _db.veterinaryDisbursements.Update(obj);
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
            if(id == null)
                return NotFound();

            // Trying To Find Data
            var data = _db.veterinaryDisbursements.Find(id);
            if(data ==  null)
                return NotFound();

            _db.veterinaryDisbursements.Remove(data);
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
            var data = _db.veterinaryDisbursements.Find(id);
            if (data == null)
                return NotFound();

            return View(data);
        }
    }
}
