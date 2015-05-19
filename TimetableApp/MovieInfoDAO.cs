using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TimetableApp
{
    class MovieInfoDAO : EntityDAO<MovieInfo>
    {
        public MovieInfoDAO(SqlConnection connection) : base(connection)
        {            
        }

        public override void save(MovieInfo entity)
        {
            throw new NotImplementedException();
        }

        public override MovieInfo find(int id)
        {
            throw new NotImplementedException();
        }

        public override IList<MovieInfo> getAll()
        {
            throw new NotImplementedException();
        }

        public override void update(MovieInfo oldEntity, MovieInfo newEntity)
        {
            throw new NotImplementedException();
        }

        public override void remove(MovieInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
