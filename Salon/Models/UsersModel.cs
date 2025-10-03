using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class UsersModel
    {
        public int user_id { get; set; }
        public string first_Name { get; set; }
        public string middle_Name { get; set; }
        public string last_Name { get; set; }
        public DateTime birth_date { get; set; }
        public string phone_Number{ get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string Position { get; set; }
    }
}
