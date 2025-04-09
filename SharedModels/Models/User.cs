using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Reservation>? Reservations { get; set; }

    }
}
