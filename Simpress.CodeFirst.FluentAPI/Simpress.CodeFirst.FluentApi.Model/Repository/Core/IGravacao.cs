using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Model.Repository.Core
{
    public interface IGravacao<TEntidade>
    {
        void Cadastrar(TEntidade entidade);
        void Atualizar(TEntidade entidade);
        void Deletar(int entidade);
    }
}
