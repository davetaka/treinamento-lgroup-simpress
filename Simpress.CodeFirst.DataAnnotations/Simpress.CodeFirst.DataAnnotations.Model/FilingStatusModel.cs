using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.DataAnnotations.Model
{
    [Table("TB_ESTADO_CIVIL")]
    public class FilingStatusModel
    {
        [Key, Column("ID_ESTADO_CIVIL", TypeName="INT")]
        public int Id { get; set; }

        [Column("DS_ESTADO_CIVIL", TypeName = "VARCHAR"), MaxLength(10), Required]
        public string Description { get; set; }
    }
}
