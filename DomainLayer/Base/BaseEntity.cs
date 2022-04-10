using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Base
{

    public abstract class BaseEntity
    {
       
    }

    public abstract class BaseEntity<T> : BaseEntity
    {
        protected BaseEntity()
        {
        }
        public T Id { get; private set; }
            public BaseEntity(T id)
            {
                Id = id;
            }
    }
}
