using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegalJuris.Model
{
    [Table("cad_cliente", Schema = "public")]
    public class ClienteModel
    {   
        [Column("id_cliente")]
        [Key]        
        public int ClienteId { get; set; }

        [Column("nome_cliente")]
        public string ClienteNome { get; set; }
    }
}