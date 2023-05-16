using LegalJuris.Model;
using System.Data.Entity;

namespace LegalJuris.Dal
{
    public class Contexto : DbContext
    {
        public Contexto() : base("LegalJurisContext") 
        {
            Database.SetInitializer<Contexto>(null);
        }

        public DbSet<ProcessoModel> ObjetoProcesso{get; set;}
        public DbSet<ClienteModel> ObjetoCliente { get; set; }
        public DbSet<CasoModel> ObjetoCaso { get; set; }
        public DbSet<ComarcaModel> ObjetoComarca { get; set; }
        public DbSet<ForoModel> ObjetoForo { get; set; }
        public DbSet<VaraModel> ObjetoVara { get; set; }
       public DbSet<ResponsavelModel> ObjetoResponsavel { get; set; }
    }

    

}
