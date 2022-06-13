using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchie1
{
    public interface IRoadVehicle : IVehicle
    {
        public float MaxLegalSpeed();

    }
}
