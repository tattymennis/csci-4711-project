using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci_4711_ess_v0.Entity
{
    public class TORequest
    {
        private int reqID;
        private DateTime start;
        private DateTime end;
        private string reason;

        public int getReqID()
        {
            return this.reqID;
        }

        public void setReqID(int value)
        {
            this.reqID = value;
        }

        public DateTime getStart()
        {
            return this.start;
        }

        public void setStart(DateTime value)
        {
            this.start = value;
        }

        public DateTime getEnd()
        {
            return this.end;
        }

        public void setEnd(DateTime value)
        {
            this.end = value;
        }

        public string getReason()
        {
            return this.reason;
        }

        public void setReason(string value)
        {
            this.reason = value;
        }
    }
}
