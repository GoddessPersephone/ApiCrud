using ApiCrud.Data;
using ApiCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiCrud.Repositorio
{
    public class RepositorioCandidato : IRepositorioCandidato
    {
        private readonly BancoContext _context;
        
        public RepositorioCandidato(BancoContext bancoContext)
        {
              _context = bancoContext;

        }
        public CandidatoModel ListarPorId(int Id)
        {

            return _context.Candidatos.FirstOrDefault(x => x.Id == Id);

        }
        public List<CandidatoModel> BuscarTodos()
        {
            return _context.Candidatos.ToList();
        }
        public CandidatoModel Adicionar(CandidatoModel candidato)
        {
            //Gravando no BancoContext
            _ = _context.Candidatos.Add(candidato);
            _context.SaveChanges();

            return candidato;
        }
    }
}
