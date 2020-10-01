using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAW_WebApi.Request
{
    public class WorkShiftRequest : IdRequest
    {
        public DateTime createTime { get; set; }
        public string content { get; set; }
        public string nameWifi { get; set; }

    }
}
