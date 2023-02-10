using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp05
{
    public class Lebewesen
    {
        public string Name { get; set; }

        public int GebJahr { get; set; }

        public Lebewesen(string name)
        {
            Name = name;
        }
    }

}
