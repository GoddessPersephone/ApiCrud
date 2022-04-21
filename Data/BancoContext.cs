using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    public class BancoContext  : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<CandidatoModel> Candidatos { get; set; }  
    
    
    }
}
