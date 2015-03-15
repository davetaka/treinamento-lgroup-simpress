using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.DataAnnotations.Model
{
    [Table("TB_AMIGO")]
    public class FriendModel
    {
        [Key, Column("ID_AMIGO", TypeName = "INT")]
        public int Id { get; set; }

        [Column("NM_AMIGO", TypeName = "VARCHAR"), MaxLength(35), Required]
        public string Name { get; set; }

        [Column("DS_EMAIL", TypeName = "VARCHAR"), MaxLength(45), Required]
        public string Email { get; set; }

        [Column("NR_TELEFONE", TypeName = "VARCHAR"), MaxLength(15), Required]
        public string Phone { get; set; }

        [Column("DT_NASCIMENTO", TypeName = "DATE"), Required]
        public DateTime BirthDate { get; set; }

        [Column("ID_SEXO", TypeName = "INT"), Required]
        public int GenderId { get; set; }

        [Column("ID_ESTADO_CIVIL", TypeName = "INT"), Required]
        public int FilingStatusId { get; set; }

#warning paramos aqui, voltar e criar as fks

    }
}
