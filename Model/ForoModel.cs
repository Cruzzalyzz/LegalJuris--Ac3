using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalJuris.Model
{
    [Table("cad_foro", Schema = "public")]
    public class ForoModel
    {
        [Column("id_foro")]
        [Key]        
        public int ForoId { get; set; }

        [Column("nome_foro")]
        public string ForoNome { get; set; }    

        [Column("id_vara")]
        public int? VaraId { get; set; }

        public virtual VaraModel Vara { get; set; }
    }
}
