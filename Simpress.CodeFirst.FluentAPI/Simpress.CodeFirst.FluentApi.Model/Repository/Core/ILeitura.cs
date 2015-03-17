using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Simpress.CodeFirst.FluentApi.Model.Repository.Core
{
    public interface ILeitura<TEntidade>
    {
        ICollection<TEntidade> Listar();

        ICollection<TEntidade> Pesquisar(Expression<Func<TEntidade, bool>> criterio);
    }
}
