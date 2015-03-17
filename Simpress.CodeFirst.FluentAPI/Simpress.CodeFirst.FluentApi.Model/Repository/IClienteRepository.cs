using Simpress.CodeFirst.FluentApi.Model.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Model.Repository
{
    public interface IClienteRepository : ILeitura<ClienteModel>, IGravacao<ClienteModel>
    {

    }
}
