using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketsWithDB.Entities
{
    public class DateEntity
    {
        public int Id { get; set; }
        public int wayId { get; set; }
        public DateTime date { get; set; }
    }
}
