using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data;
using System.Linq.Expressions;
using System.Data.Metadata.Edm;

namespace DAL
{
    public class GenericDAO<E> : IDao<E>, IDisposable
        where E : EntityObject
    {
        /// Repositório genérico para o Entity Framework com as operações mais 
        /// comuns de persistência, como inserção, atualização,
        /// exclusão e seleção.

        /// Contexto do Entity Framework
        public ObjectContext Context
        {
            get { return ContextManager.CurrentContext; }
        }


        /// Retorna o nome do EntitySet do objeto persistente
        private string entitySetName;

        /// Retorna o nome do EntitySet do objeto persistente
        protected string EntitySetName
        {
            get
            {
                if (String.IsNullOrEmpty(entitySetName))
                {
                    entitySetName = GetEntitySetName(typeof(E).Name);
                }

                return entitySetName;
            }
        }


        /// Insere um novo objeto persistente
        public void Insert(E entity)
        {
            Context.AddObject(EntitySetName, entity);
            Context.SaveChanges();
            Dispose();
        }

        /// Atualiza um objeto existente.
        public void Update(E entity)
        {

            EntityKey key;
            object originalItem;
            sysnewsEntities entitys;
            using (entitys = new sysnewsEntities())
            {
                key = entitys.CreateEntityKey(entity.EntityKey.EntitySetName, entity);

                if (entitys.TryGetObjectByKey(key, out originalItem))
                {
                    entitys.ApplyCurrentValues(key.EntitySetName, entity);
                }
                entitys.SaveChanges();
                entitys.Dispose();
                
            }
        }
     
        //    EntityKey key;
        //    object originalItem;

        //   // if (entity.EntityKey == null)
        //        // Obtém o entity key do objeto que será atualizado
        //        key = Context.CreateEntityKey(EntitySetName, entity);
        //    //else
        //      //  key = entity.EntityKey;
        //    try
        //    {
        //        // Obtém o objeto original
        //        if (Context.TryGetObjectByKey(key, out originalItem))
        //        {
        //            if (originalItem is EntityObject &&
        //                ((EntityObject)originalItem).EntityState != EntityState.Added)
        //            {
        //                // Autaliza o objeto
        //               Context.ApplyCurrentValues(key.EntitySetName, entity);
        //               Context.SaveChanges();
        //               Dispose();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        /// Exclui um objeto persistente
        public void Delete(E entity)
        {
            Context.DeleteObject(entity);
            Context.SaveChanges();
            Dispose();
        }

        /// Retorna um objeto que satisfaça a cláusula passada como parâmetro.
        public E SelectOne(Expression<Func<E, bool>> where)
        {
            return Context.CreateQuery<E>(EntitySetName).Where(where).FirstOrDefault();
        }


        /// Salva as alterações no banco de dados.
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
      

        /// Retorna todos os objetos persistentes.
        public List<E> SelectAll()
        {
            return Context.CreateQuery<E>(EntitySetName).ToList();
        }

        /// Retorna um IQueryable com todos os objetos
        public IQueryable<E> QueryAll()
        {
            return Context.CreateQuery<E>(EntitySetName).AsQueryable<E>();
        }

        /// Retorna todos os objetos usando paginação.
        public List<E> SelectAll(int maximumRows, int startRowIndex)
        {
            return Context.CreateQuery<E>(EntitySetName).Skip<E>(startRowIndex).Take(maximumRows).ToList<E>();
        }

        /// Retorna um IQueryable com todos os objetos usando paginação
        public IQueryable<E> QueryAll(int maximumRows, int startRowIndex)
        {
            return Context.CreateQuery<E>(EntitySetName).Skip<E>(startRowIndex).Take(maximumRows);
        }

        /// Retorna todos os objetos que satisfaçam a cláusula passada
        public List<E> SelectWhere(Expression<Func<E, bool>> where)
        {
            return Context.CreateQuery<E>(EntitySetName).Where(where).ToList<E>();
        }

        /// Retorna todos os objetos que satisfaçam a cláusula passada, usando paginação
        public List<E> SelectWhere(Expression<Func<E, bool>> where, int maximumRows, int startRowIndex)
        {
            return Context.CreateQuery<E>(EntitySetName).Where(where)

                          .Skip<E>(startRowIndex).Take(maximumRows).ToList();
        }

        /// Retorna o número de objetos
        public int GetCount()
        {
            return Context.CreateQuery<E>(EntitySetName).Count();
        }

        /// Retorna o número de objetos que satisfaçam a cláusula passada
        public int GetCount(Expression<Func<E, bool>> where)
        {
            return Context.CreateQuery<E>(EntitySetName).Where(where).Count();
        }

        /// Libera os recursos do Entity Framework.
        public void Dispose()
        {
            //if (Context != null)
                //Context.Dispose();
        }

        /// Retorna o nome do EntitySet, possibilitando a criação de métodos genéricos.
        private string GetEntitySetName(string entityTypeName)
        {
            var container = Context.MetadataWorkspace
                                            .GetEntityContainer(Context.DefaultContainerName,
                                                                       DataSpace.CSpace);
            string entitySetName = (from meta in container.BaseEntitySets
                                    where meta.ElementType.Name == entityTypeName
                                    select meta.Name).FirstOrDefault();

            return entitySetName;
        }
    }
}

