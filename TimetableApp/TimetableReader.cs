using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace TimetableApp
{
    public class TimetableReader
    {
        private string source;
        public dynamic json;

        public TimetableReader(string source)
        {
            this.source = source;
            json = Json.Decode(source);
        }

        public String Status
        {
            get 
            { 
                return json.Status;
            }
        }

        public Channel GetChannel(string name)
        {
            foreach (var channel in json.Channel_Type["1"])
            {
                if (name.Equals(channel.Name))
                {
                    return channel;
                }
            }
            return null;
        }
    }
}
