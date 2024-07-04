using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketsWithDB.Entities
{
    public class WaypointEntity
    {
        public int Id { get; set; }
        public int wayId { get; set; }
        public string name { get; set; }
        public TimeSpan stoptime { get; set; }
        public int countnumber { get; set; }
    }
}
