
using System;
using System.Collections.Generic;

namespace ControlNomadApp
{
    public class Journal
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}