using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketsWithDB.Entities
{
    public class TicketEntity
    {
        public int Id { get; set; }

        public int? userId {  get; set; }
        public string? PIB { get; set; }
        public int wayId { get; set; }
        
        public string startpoint {  get; set; }
        public string stoppoint {  get; set; }
        
        public double price { get; set; }
        
        public DateTime selldate {  get; set; }
        public DateTime godate {  get; set; }

        public TimeSpan gotime { get; set; }
        public TimeSpan endtime { get; set; }
    }
}
