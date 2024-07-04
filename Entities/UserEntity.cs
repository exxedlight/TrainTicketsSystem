using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketsWithDB.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string login {  get; set; }
        public string password { get; set; }
        
        public string name { get; set; }
        public string surname { get; set; }
        public string father { get; set; }
        
        public int role { get; set; }
    }
}
