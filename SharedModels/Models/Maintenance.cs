using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string Status { get; set; }

        public int RoomId { get; set; }

        public virtual Room Room { get; set; }


    }
}
