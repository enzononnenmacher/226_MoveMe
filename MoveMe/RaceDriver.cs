using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class RaceDriver : Driver
    {
        public RaceDriver(Vehicle vehicle) : base(vehicle)
        {

        }

        public override string Eat()
        {
            if (base._vehicle.MotorState == true)
            {
                throw new ExceptionEat();
            }
            return base.Eat();
        }
    }

    public class ExceptionRaceDriver : Exception { };

    public class ExceptionEat : ExceptionRaceDriver { };
}
