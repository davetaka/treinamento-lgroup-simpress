using System;
using System.Collections.Generic;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Models
{
    public partial class TB_SEXO
    {
        public TB_SEXO()
        {
            this.TB_AMIGO = new List<TB_AMIGO>();
        }

        public int ID_SEXO { get; set; }
        public string DS_SEXO { get; set; }
        public string DS_TESTE { get; set; }
        public Nullable<int> IT_TESTE { get; set; }
        public virtual ICollection<TB_AMIGO> TB_AMIGO { get; set; }
    }
}
