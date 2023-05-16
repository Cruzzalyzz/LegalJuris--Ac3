using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalJuris.Model
{
    [Table("cad_vara", Schema = "public")]
    public class VaraModel
    {
        [Column("id_vara")]
        [Key]        
        public int VaraId { get; set; }

        [Column("nome_vara")]
        public string VaraNome { get; set; }
        
    }
}
