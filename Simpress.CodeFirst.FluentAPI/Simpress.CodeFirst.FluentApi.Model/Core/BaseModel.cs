using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Model.Core
{
    //Apos desenhar as classes (dll) é sempre bacanca
    //refatorar o codigo (coding refactoring) é a técnica
    //de melhorar o código visando boas praticas, performance
    //seguranca e orientação a objetos
    //Core são os principais componentes da dll
    //Base é um classe pai, é a classe pai de todas as classes
    //de modelo
    //Os componentes tem que estar o maximo possivel fechados
    //Quanto mais deixarmos incorruptiveis melhor
    //a prova de cagadas de programador
    //quando criamos uma classe podemos consumir ela de 2 formas
    //heranca => :, pra bloquear a herança, pra ela não ser 
    //pai de ninguem colocar o sealed (castramos a classe)
    //instancia=> NEW, pra bloquear o new colocar o abstract
    
    public abstract class BaseModel
    {
        public Int32 Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
