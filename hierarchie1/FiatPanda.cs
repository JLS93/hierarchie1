using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchie1
{
    public class FiatPanda : ICar, IRoadVehicle, IVehicle
    {
        public FiatPanda(CarTemplate car)
        {
            carTemplate = car;
        }
        CarTemplate carTemplate;

        public string LicencePlate()
        {
            return ((IVehicle)carTemplate).LicencePlate();
        }

        public float MaxLegalSpeed()
        {
            return ((IRoadVehicle)carTemplate).MaxLegalSpeed();
        }

        public int MaxPassengerCount()
        {
            return ((ICar)carTemplate).MaxPassengerCount();
        }
    }
}
