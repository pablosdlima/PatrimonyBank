using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PatrimonyBank.Data;
using PatrimonyBank.Models;

namespace PatrimonyBank.Controllers
{
    public class InvestidorsController : Controller
    {
        private readonly PatrimonyContext _context;

        public InvestidorsController(PatrimonyContext context)
        {
            _context = context;
        }

        // GET: Investidors
        public IActionResult GerenciaInvestidor(int? msg)
        {
            if(msg == 1) ViewBag.CPFeCNPJ = "CPF não encontrado"; 
            if(msg == 2) ViewBag.CPFeCNPJ = "CNPJ não encontrado"; 

            //return View(await _context.Investidor.ToListAsync());
            return View();
        }
    }
}
