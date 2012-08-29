using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public interface IDao<E>
    {
        /// Inserção
        void Insert(E entity);

        /// Atualização
        void Update(E entity);

        /// Exclusão
        void Delete(E entity);

        /// Retorna o objeto que satisfaça a cláusula passada como argumento (cláusula WHERE)
        E SelectOne(Expression<Func<E, bool>> where);

        /// Retorna todos os objetos de um tipo
        List<E> SelectAll();

        /// Retorna os objetos usando paginação
        List<E> SelectAll(int maximumRows, int startRowIndex);

        /// Retorna todos os objetos que satisfaçam a cláusula passada
        List<E> SelectWhere(Expression<Func<E, bool>> where);

        /// Retorna os objetos que satisfaçam a cláusula passada, usando paginação
        List<E> SelectWhere(Expression<Func<E, bool>> where, int maximumRows, int startRowIndex);

        /// Retorna um objeto IQueryable, possibilitando formar queries usando expressões Lambda
        IQueryable<E> QueryAll();

        /// Retorna um IQueryable com os objetos usando paginação
        IQueryable<E> QueryAll(int maximumRows, int startRowIndex);

        /// Retorna a quantidade de objetos persistentes.
        int GetCount();

        /// Retorna a quantidade de objetos persistentes que satisfaçam a cláusula WHERE
        int GetCount(Expression<Func<E, bool>> where);
    }
}
