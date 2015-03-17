using Simpress.CodeFirst.FluentApi.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Model
{
    //quando fechamos uma classe (sealed)
    //ela nao vai ser herdada e por tras dos panos a clr
    //otimiza o acesso a classes seladas, sao processadas de forma
    //mais rapida
    public sealed class ClienteModel : BaseModel
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Endereco { get; set; }
        public String CPF { get; set; }

    }
}
