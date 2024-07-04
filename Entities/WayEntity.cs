using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketsWithDB.Entities
{
    public class WayEntity
    {
        public int Id { get; set; }
        public string number { get; set; }
        public double priceperpoint { get; set; }
    }
}
