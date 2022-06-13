using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchie1
{
    public class DaciaSandeco : ICar, IRoadVehicle, IVehicle
    {
        public DaciaSandeco(CarTemplate car)
        {
            carTemplate = car;
        }

        CarTemplate carTemplate;

        public int MaxPassengerCount()
        {
            return 5;
        }

        public float MaxLegalSpeed()
        {
            return 250;
        }

        public string LicencePlate()
        {
            return "ad 962 hf";
        }
    }
}
