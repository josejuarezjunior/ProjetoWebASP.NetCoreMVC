using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()//Controller chamando a função
        {
            var list = _sellerService.FindAll();//Função no Model(FindAll)
            return View(list);//Resultado enviado para a View
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//Evita ataque malicioso durante autenticação
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            //Redirecionando para o Index de vendedores
            return RedirectToAction(nameof(Index));
        }
    }
}
