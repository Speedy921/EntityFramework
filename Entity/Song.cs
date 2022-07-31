using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Groupid { get; set; }

        public virtual Group Group { get; set; }
    }
}
