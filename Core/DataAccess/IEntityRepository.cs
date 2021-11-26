using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{// Core katmanı diğer katmanları referans almaz
                                          //Generic Constraint(Generic Kısıt)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {                   //Delege ve Linq
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filter=null-- Filtre vermeye de bilirsin demek
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
