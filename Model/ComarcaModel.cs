using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalJuris.Model
{
    [Table("cad_comarca", Schema = "public")]
    public class ComarcaModel
    {
        [Column("id_comarca")]
        [Key]        
        public int ComarcaId { get; set; }

        [Column("nome_comarca")]
        public string ComarcaNome { get; set; }

        [Column("id_foro")]
        public int? ForoId { get; set; }

        public virtual ForoModel Foro { get; set; }
    }
}
