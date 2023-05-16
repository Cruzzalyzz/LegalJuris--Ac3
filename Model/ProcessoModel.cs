using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalJuris.Model
{
    [Table("jur_processo", Schema = "public")]
    public class ProcessoModel
    {
        [Column("id_processo")]
        [Key]
        public int ProcessoId { get; set; }

        [Column("numero_processo")]
        public string NumeroProcesso { get; set; }

        [Column("id_responsavel")]
        public int? ResponsavelId { get; set; }

        public virtual ResponsavelModel Responsavel { get; set; }

        [Column("id_caso")]
        public int? CasoId { get; set; }

        public virtual CasoModel Caso { get; set; }

        [Column("id_comarca")]
        public int? ComarcaId { get; set; }

        public virtual ComarcaModel Comarca { get; set; }
    }
}
