using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreBL;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class LocationController : Controller
    {
        private IStoreBL _storeBL;
        private IMapper _mapper;
    
    public LocationController(IStoreBL storeBL, IMapper mapper)
    {
        _storeBL = storeBL;
        _mapper = mapper;
    }
        // GET: LocationController
        public ActionResult Index()
        {
            return View(_storeBL.GetLocations().Select(location => _mapper.cast2LocationIndexVM(location)).ToList());
        }

        // GET: LocationController/Details/5
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2LocationCRVM(_storeBL.GetLocationByName(name)));
        }






        // GET: LocationController/Create
        public ActionResult Create()
        {
            return View("CreateLocation");
        }

        // POST: LocationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LocationCRVM newLocation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _storeBL.AddLocation(_mapper.cast2Location(newLocation));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }        

        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocationController/Edit/5
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

        // GET: LocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocationController/Delete/5
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
