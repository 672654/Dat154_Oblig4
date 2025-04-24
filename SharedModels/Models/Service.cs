using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceMessage { get; set; }

        public string ServiceStatus { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

    }
}
