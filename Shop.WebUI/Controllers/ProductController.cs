using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Domain.Abstract;
using Shop.Domain.Entities;

namespace Shop.WebUI.Controllers
{
    public class ProductController : Controller
    {

        private IProductRepository repository;
        public   ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }
        // GET: Poroduct
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}