using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //Generic constraint : IEntityRepository<T> içerisindeki T'nin neler olabileceğini belirlememize yaramaktadır. Yani T hangi veri tiplerinden olması gerekiyorsa (int, string, class, object vs.)  ona göre kısıtlamaya gidilir.

    //class tibi referans tip anlamıa gelmektedir.

    //IEntiy olabilir yada IEntity implement eden bir nesne de olabilir.

    //new() demek ise new'lenebilir oladuğu anlamına gelebilir. Yani Interface'ler new2lenemediği için T sadece IEntity den implemente edilen class (nesne)lardan biri olabilir.

    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        //Expression yapısı verileri belirli bir filtreye göre getirmek için kullanılmaktadır.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter = null);

        //Expression kullandığımız için aşağıdaki koda ihtiyacımız kalmamaktadır. (Expression kullanmadan önce burası aktifti.)

        //List<T> GetById(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
