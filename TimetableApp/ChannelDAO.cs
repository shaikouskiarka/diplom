using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TimetableApp
{
    class ChannelDAO : EntityDAO<Channel>
    {
        public ChannelDAO(SqlConnection connection) : base(connection)
        {
        }

        public override void save(Channel entity)
        {
            throw new NotImplementedException();
        }

        public override Channel find(int id)
        {
            throw new NotImplementedException();
        }

        public override IList<Channel> getAll()
        {
            throw new NotImplementedException();
        }

        public override void update(Channel oldEntity, Channel newEntity)
        {
            throw new NotImplementedException();
        }

        public override void remove(Channel entity)
        {
            throw new NotImplementedException();
        }
    }
}
