using System;
using System.Collections.Generic;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Models
{
    public partial class TB_AMIGO
    {
        public int ID_AMIGO { get; set; }
        public int ID_SEXO { get; set; }
        public string NM_AMIGO { get; set; }
        public string DS_EMAIL { get; set; }
        public string NR_TELEFONE { get; set; }
        public System.DateTime DT_NASCIMENTO { get; set; }
        public virtual TB_SEXO TB_SEXO { get; set; }
    }
}
