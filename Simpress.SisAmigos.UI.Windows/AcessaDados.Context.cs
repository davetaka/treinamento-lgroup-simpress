﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SIMPRESSEntities : DbContext
    {
        public SIMPRESSEntities()
            : base("name=SIMPRESSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_AMIGO> TB_AMIGO { get; set; }
        public virtual DbSet<TB_ESCOLARIDADE> TB_ESCOLARIDADE { get; set; }
        public virtual DbSet<TB_SEXO> TB_SEXO { get; set; }
    
        public virtual int INSERIR_AMIGO(string pNM_AMIGO, string pDS_EMAIL, string pNR_TELEFONE, Nullable<System.DateTime> pDT_NASCIMENTO)
        {
            var pNM_AMIGOParameter = pNM_AMIGO != null ?
                new ObjectParameter("pNM_AMIGO", pNM_AMIGO) :
                new ObjectParameter("pNM_AMIGO", typeof(string));
    
            var pDS_EMAILParameter = pDS_EMAIL != null ?
                new ObjectParameter("pDS_EMAIL", pDS_EMAIL) :
                new ObjectParameter("pDS_EMAIL", typeof(string));
    
            var pNR_TELEFONEParameter = pNR_TELEFONE != null ?
                new ObjectParameter("pNR_TELEFONE", pNR_TELEFONE) :
                new ObjectParameter("pNR_TELEFONE", typeof(string));
    
            var pDT_NASCIMENTOParameter = pDT_NASCIMENTO.HasValue ?
                new ObjectParameter("pDT_NASCIMENTO", pDT_NASCIMENTO) :
                new ObjectParameter("pDT_NASCIMENTO", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERIR_AMIGO", pNM_AMIGOParameter, pDS_EMAILParameter, pNR_TELEFONEParameter, pDT_NASCIMENTOParameter);
        }
    
        public virtual ObjectResult<TB_AMIGO> ListarAmigos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TB_AMIGO>("ListarAmigos");
        }
    
        public virtual ObjectResult<TB_AMIGO> ListarAmigos(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TB_AMIGO>("ListarAmigos", mergeOption);
        }
    
        public virtual ObjectResult<TotalAmigos_Result> TotalAmigos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TotalAmigos_Result>("TotalAmigos");
        }
    }
}