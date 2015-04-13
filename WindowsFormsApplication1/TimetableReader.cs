using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace WindowsFormsApplication1
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
    }
}
