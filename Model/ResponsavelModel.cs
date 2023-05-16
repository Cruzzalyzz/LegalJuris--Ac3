using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalJuris.Model
{
    [Table("cad_responsavel", Schema = "public")]
    public class ResponsavelModel
    {
        [Column("id_responsavel")]
        [Key]
        public int ResponsavelId { get; set; }

        [Column("nome_responsavel")]
        public string NomeResponsavel { get; set; }
    }
}
