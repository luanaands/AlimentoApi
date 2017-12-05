using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class UnitOfWork : IUnitOfWork
    {
        private Contexto _contexto;

        public Contexto contexto
        {
            get { return this._contexto; }
        }

        public UnitOfWork()
        {
            this._contexto = new Contexto();
        }

        public void Commit()
        {
            this.contexto.SaveChanges();
        }

        #region IUnitOfWork Members


        public void CommitAndRefreshChanges()
        {
            throw new NotImplementedException();
        }

        public void RollbackChanges()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (this._contexto != null)
            {
                this._contexto.Dispose();
                GC.SuppressFinalize(this);
            }
        }

        #endregion
       
    }

}