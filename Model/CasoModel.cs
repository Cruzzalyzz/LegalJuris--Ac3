using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalJuris.Model
{
    [Table("cad_caso", Schema = "public")]
    public class CasoModel
    {
        [Column("id_caso")]
        [Key]        
        public int CasoId { get; set; }

        [Column("nome_caso")]
        public string CasoNome { get; set; }

        [Column("id_cliente")]
        public Int32? ClienteId { get; set; }

        public virtual ClienteModel Cliente { get; set; }

    }
}
