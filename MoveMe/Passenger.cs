using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class Passenger : Person
    {
        private bool _seePaysage;

        public string SeePaysage()
        {
            return "Je profite du paysage";
        }
    }
}
