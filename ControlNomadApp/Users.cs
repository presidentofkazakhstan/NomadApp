
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ControlNomadApp
{
    public class Users
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string City { get; set; }

        public string Adress { get; set; }

        public int Subscription { get; set; }

        public DateTime BuyDate { get; set; }

        public string CardNumber { get; set; }

        public int SummWallet { get; set; }

        public virtual Journal Journal { get; set; }



    }
}