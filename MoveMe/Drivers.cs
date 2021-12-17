using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class Driver : Person
    {
        #region private attributs
        private protected Vehicle _vehicle;
        #endregion

        #region public methods
        public Driver(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public Vehicle Vehicle
        {
            get
            {
                return _vehicle;
            }
        }

        public void StartMotor()
        {
            _vehicle.MotorStart();
        }

        public void StopMotor()
        {
            _vehicle.MotorStop();
        }

        public override string Sleep()
        {
            if (_vehicle.MotorState == true)
            {
                _vehicle.MotorStop();
            }
            return base.Sleep();
        }

        #endregion
    }
}
