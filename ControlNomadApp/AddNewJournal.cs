using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNomadApp
{
  public  class AddNewJournal
    {
        public AddNewJournal()
        {
            using (var context = new UserContext())
            {
                Console.Write("Введите имя журнала: ");
                var journalname = Console.ReadLine();

                var journal = new Journal
                {
                    Name = journalname

                };

                context.Journals.Add(journal);
                context.SaveChanges();
            }
        }
    }
}
