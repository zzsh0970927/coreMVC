using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVC.Models
{
    public class dt_users
    {
        public int Id { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
        public string UserName { get; set; }
        public int Del { get; set; }

    }
}
