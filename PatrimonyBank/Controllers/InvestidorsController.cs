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
        public async Task<IActionResult> GerenciaInvestidor()
        {
            return View(await _context.Investidor.ToListAsync());
        } 

        public async Task<IActionResult> Index()
        {
            return View(await _context.Investidor.ToListAsync());
        }

        // GET: Investidors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investidor = await _context.Investidor
                .FirstOrDefaultAsync(m => m.IdInvestidor == id);
            if (investidor == null)
            {
                return NotFound();
            }

            return View(investidor);
        }

        // GET: Investidors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Investidors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdInvestidor,Cnpj,CPF,Nascimento,Nacionalidade,Naturalidade,TipoDocumento,OrgaoEmissor,DataEmissao,NomeMae,NomePai,EstadoCivil,NomeConjuge,PaisDomicilioFiscal,PaisDomicilioFiscalOutro,PaisCidadania,PaisCidadaniaOutro,Telefone,Email,Endereco,Numero,Complemento,Bairro,Cep,Cidade,Estado,Pais,OcupacaoProfissional,Empresa,CNPJEmpregativo,EnderecoEmpresa,NumeroEmpresa,ComplementoEmpresa,BairroEmpresa,CepEmpresa,CidadeEmpresa,EstadoEmpresa,PaisEmpresa")] Investidor investidor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(investidor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(investidor);
        }

        // GET: Investidors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investidor = await _context.Investidor.FindAsync(id);
            if (investidor == null)
            {
                return NotFound();
            }
            return View(investidor);
        }

        // POST: Investidors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdInvestidor,Cnpj,CPF,Nascimento,Nacionalidade,Naturalidade,TipoDocumento,OrgaoEmissor,DataEmissao,NomeMae,NomePai,EstadoCivil,NomeConjuge,PaisDomicilioFiscal,PaisDomicilioFiscalOutro,PaisCidadania,PaisCidadaniaOutro,Telefone,Email,Endereco,Numero,Complemento,Bairro,Cep,Cidade,Estado,Pais,OcupacaoProfissional,Empresa,CNPJEmpregativo,EnderecoEmpresa,NumeroEmpresa,ComplementoEmpresa,BairroEmpresa,CepEmpresa,CidadeEmpresa,EstadoEmpresa,PaisEmpresa")] Investidor investidor)
        {
            if (id != investidor.IdInvestidor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(investidor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvestidorExists(investidor.IdInvestidor))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(investidor);
        }

        // GET: Investidors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investidor = await _context.Investidor
                .FirstOrDefaultAsync(m => m.IdInvestidor == id);
            if (investidor == null)
            {
                return NotFound();
            }

            return View(investidor);
        }

        // POST: Investidors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var investidor = await _context.Investidor.FindAsync(id);
            _context.Investidor.Remove(investidor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvestidorExists(int id)
        {
            return _context.Investidor.Any(e => e.IdInvestidor == id);
        }
    }
}
