using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNomadApp
{
    public class DeliveryJournals
    {
        public DeliveryJournals()
        {
            using (var context = new UserContext())
            {
                foreach (var user in context.Users)
                {
                    Console.WriteLine(user.Adress + " отправлено");
                }

            }
            Console.ReadLine();
        }
    }
}
