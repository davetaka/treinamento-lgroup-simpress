using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simpress.CodeFirst.DataAnnotations.Model
{
    [Table("TB_SEXO")]
    public class GenderModel
    {
        [Key, Column("ID_SEXO", TypeName = "INT")]
        public int Id { get; set; }

        [Required, Column("DS_SEXO", TypeName = "VARCHAR"), MaxLength(9)]
        public string Description { get; set; }
    }
}
