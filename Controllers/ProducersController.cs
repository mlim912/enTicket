using enTicket.Data;
using enTicket.Data.Services;
using enTicket.Data.Static;
using enTicket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace enTicket.Controllers
{
    [Authorize(Roles =UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        [AllowAnonymous]

        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        [AllowAnonymous]
        //Get: producers/details/1 
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIDAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //Get: producers/create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName, Bio")]Producer producer)
        {
            if(!ModelState.IsValid) return View(producer);

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //Get: producers/edit

         
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIDAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Bio")] Producer producer)
        {
            if (ModelState.IsValid)
            {

                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));

            }
            return View(producer);

        }

        //Get: Producers/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIDAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIDAsync(id);
            if (producerDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));


        }


    }
}
