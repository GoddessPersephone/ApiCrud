using ApiCrud.Models;
using ApiCrud.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiCrud.Controllers
{
    public class CandidatoController : Controller

    {
        private readonly IRepositorioCandidato _repositorioCandidato;
        public CandidatoController(IRepositorioCandidato repositorioCandidato)
        {
            _repositorioCandidato = repositorioCandidato;
        }
        public IActionResult Index()
        {
            var candidatos = _repositorioCandidato.BuscarTodos();
            return View(candidatos);
        
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            CandidatoModel candidatos = _repositorioCandidato.ListarPorId(id);
            return View(candidatos);
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Criar(CandidatoModel candidato)
        {
            _repositorioCandidato.Adicionar(candidato);

            return RedirectToAction("Index");
        }


}
}
