using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TimetableApp
{
    abstract class EntityDAO<T>
    {
        protected SqlConnection connection;

        public EntityDAO(SqlConnection connection)
        {
            this.connection = connection;
        }

        public abstract void save(T entity);

        public abstract T find(int id);

        public abstract IList<T> getAll();

        public abstract void update(T oldEntity, T newEntity);

        public abstract void remove(T entity);
    }
}
