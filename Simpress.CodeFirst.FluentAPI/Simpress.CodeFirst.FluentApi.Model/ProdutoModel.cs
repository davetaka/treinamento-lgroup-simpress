using Simpress.CodeFirst.FluentApi.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Model
{
    //Todos os campos duplicados (repetidos) descem da
    //Super classe (Super Tido)
    //Pastas viram nasmespaces
    public sealed class ProdutoModel : BaseModel
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }
        public Boolean Status { get; set; }

        public String Fornecedor { get; set; }

        public string Fabricante { get; set; }

        
    }
}
