using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMedicine.Models;

namespace TheMedicine.Interfaces
{
    public interface IProtocolModel
    {
        int AddProtocol(ProtocolModel protocolModel);
        void DeleteProtocol(int idProtocol);

    }
}
