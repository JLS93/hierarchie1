using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchie1
{
    class MercedesAccros : ITruck
    {
        public string LicencePlate()
        {
            throw new NotImplementedException();
        }

        public float MaxFreight()
        {
            throw new NotImplementedException();
        }

        public float MaxLegalSpeed()
        {
            throw new NotImplementedException();
        }

        TruckTemplate[] listTruckTemplate;
        MercedesAccros(TruckTemplate[] valeur)
        {
            listTruckTemplate = valeur;
        }
    }
}
