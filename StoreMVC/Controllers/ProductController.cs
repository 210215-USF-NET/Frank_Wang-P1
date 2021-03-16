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
    public class ProductController : Controller
    {
        private IStoreBL _storeBL;
        private IMapper _mapper;
        public ProductController(IStoreBL storeBL, IMapper mapper)
        {
            _storeBL = storeBL;
            _mapper = mapper;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(_storeBL.GetProduct().Select(product => _mapper.cast2ProductIndexVM(product)).ToList());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2ProductCRVM(_storeBL.GetProductByName(name)));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View("CreateProduct");
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCRVM newProduct)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _storeBL.AddProduct(_mapper.cast2Product(newProduct));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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
        public ActionResult Delete(string name)
        {
            _storeBL.DeleteProduct(_storeBL.GetProductByName(name));
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        // public ActionResult Delete(int id)
        //  {
        //      return View();
        //  }

        // POST: ProductController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        // public ActionResult Delete(int id, IFormCollection collection)
        // {
        //   try
        //   {
        //      return RedirectToAction(nameof(Index));
        //   }
        //  catch
        //  {
        //     return View();
        // }
        //   }
    }
}
