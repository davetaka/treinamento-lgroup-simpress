using Simpress.CodeFirst.FluentApi.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Model
{
    public sealed class PedidoModel : BaseModel
    {
        public Int32 CodigoCliente { get; set; }
        public String Observacao { get; set; }

        //Criamos a composição (Propriedade de Navegação)
        public ClienteModel Cliente { get; set; }
    }
}
