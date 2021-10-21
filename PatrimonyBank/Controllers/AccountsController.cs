using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PatrimonyBank.Data;
using PatrimonyBank.Reader;
using PatrimonyBank.Services;
using PatrimonyBank.ViewMoldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PatrimonyBank.Controllers
{
    public class AccountsController : Controller
    {
        private readonly PatrimonyContext _context;

        //public AccountsController(PatrimonyContext context)
        //{
        //    _context = context;
        //}

        //[HttpPost]
        //public async Task<IActionResult>GetAccountsPF(string Cpf)
        //{
        //    return RedirectToAction("DetailsGetAccounts", new { cpf = Cpf });
        //}

        public async Task<IActionResult> DetailsGetAccounts(string cpf)
        {
            Accounts_services objAPI = new();

            if (cpf == null)
            {
                return NotFound();
            }

            AccountPFVm obj = await objAPI.AccountPF(cpf);

            ReaderPDF readerPDF = new();
            readerPDF.ReadPdf(obj);

            return View(obj);
        }

        public async Task<IActionResult> DetailsGetAccountsPJ(string Cnpj)
        {
            Accounts_services objAPI = new();
            AccountsPJVm obj = await objAPI.AccountPJ(Cnpj);

            if (Cnpj == null)
            {
                return NotFound();
            } 

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }   

    }
}



