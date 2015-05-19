using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TimetableApp
{
    class BroadcastDAO : EntityDAO<Broadcast>
    {
        public BroadcastDAO(SqlConnection connection)
            : base(connection)
        {            
        }

        public override void save(Broadcast entity)
        {
            throw new NotImplementedException();
        }

        public override Broadcast find(int id)
        {
            throw new NotImplementedException();
        }

        public override IList<Broadcast> getAll()
        {
            throw new NotImplementedException();
        }

        public override void update(Broadcast oldEntity, Broadcast newEntity)
        {
            throw new NotImplementedException();
        }

        public override void remove(Broadcast entity)
        {
            throw new NotImplementedException();
        }
    }
}
