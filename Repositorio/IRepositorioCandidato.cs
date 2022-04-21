using ApiCrud.Models;
using System.Collections.Generic;

namespace ApiCrud.Repositorio
{
    public interface IRepositorioCandidato
    {   
        CandidatoModel ListarPorId(int Id);
        List<CandidatoModel> BuscarTodos();
        CandidatoModel Adicionar(CandidatoModel candidato);
    }
}
