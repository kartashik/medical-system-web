using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMedicine.Interfaces;
using TheMedicine.Models;

namespace TheMedicine.Data.Entity
{
    public class Protocol : IProtocolModel
    {
        private readonly ApplicationContext appDBContent;
        public int AddProtocol(ProtocolModel protocolModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteProtocol(int idProtocol)
        {
            throw new NotImplementedException();
        }
    }
}
