﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Repositorio.Contexto;

namespace TodoPagos.Repositorio
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal ContextoTodoPagos contexto;
        internal DbSet<T> dbSet;

        public Repository(ContextoTodoPagos contexto)
        {
            this.contexto = contexto;
            this.dbSet = contexto.Set<T>();
        }

        public void Actualizar(T t)
        {
            dbSet.Attach(t);
            contexto.Entry(t).State = EntityState.Modified;
        }

        public void Agregar(T t)
        {
            dbSet.Add(t);
        }

        public void Borrar(object id)
        {
            T entidad = dbSet.Find(id);
            Borrar(entidad);
        }

        public void Borrar(T t)
        {
            if(contexto.Entry(t).State == EntityState.Detached)
            {
                dbSet.Attach(t);
            }

            dbSet.Remove(t);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Obtener(object t)
        {
            return dbSet.Find(t);
        }
    }
}