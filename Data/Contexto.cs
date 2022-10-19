using Microsoft.EntityFrameworkCore;
using testeBD.Models;

namespace testeBD.Data
{
    public class Contexto : DbContext
    {
        //construtor que passa a string de conexão do banco
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        //Define quais tabelas, criação de bd e etc

        public DbSet<Usuario> Usuario { get; set; }
    }
}
