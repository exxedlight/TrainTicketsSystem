using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketsWithDB.Entities
{
    public class CodeEntity
    {
        public int Id { get; set; }
        public string code {  get; set; }
        public int role { get; set; }
    }
}
