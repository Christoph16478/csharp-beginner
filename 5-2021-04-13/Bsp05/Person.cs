using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp05
{
    class Person : Lebewesen
    {
        public Person(string name) : base(name) // base bedeutet hier Elternklasse. Der 'name' wird an diese Übergeben. Dies wird bei MEthoden eingesetzt
        {
            
        }
    }
}
