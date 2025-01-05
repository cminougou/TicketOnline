using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketOnline.Controllers
{
    public class GerisController : Controller
    {
        // GET: GerisController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GerisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GerisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GerisController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: GerisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GerisController/Edit/5
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

        // GET: GerisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GerisController/Delete/5
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
