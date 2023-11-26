using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LESSON12._3___Interfaces
{
    public interface IVehicle
    {
        void Drive()
        {

        }
        bool Refuel(int gasoline)
        {
            return false;
        }
    }
}
