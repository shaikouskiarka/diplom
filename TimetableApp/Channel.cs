using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimetableApp
{
    public class Channel
    {
        private string name;
        private IList<Broadcast> schedule;

        public Channel(string name, IList<Broadcast> schedule)
        {
            this.name = name;
            this.schedule = schedule;
        }

        public IList<Broadcast> GetSchedule()
        {
            throw new System.NotImplementedException();
        }
    }
}
