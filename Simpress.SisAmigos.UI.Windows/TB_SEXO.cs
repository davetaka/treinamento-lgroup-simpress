//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simpress.SisAmigos.UI.Windows
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_SEXO
    {
        public TB_SEXO()
        {
            this.TB_AMIGO = new HashSet<TB_AMIGO>();
        }
    
        public int ID_SEXO { get; set; }
        public string DS_SEXO { get; set; }
        public string DS_TESTE { get; set; }
        public Nullable<int> IT_TESTE { get; set; }
    
        public virtual ICollection<TB_AMIGO> TB_AMIGO { get; set; }
    }
}
