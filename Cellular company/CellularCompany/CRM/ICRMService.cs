using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRM
{
    [ServiceContract]
    public interface ICRMService
    {

        //[OperationContract]
        //List<ClientTypeDto> GetClientTypes();
    }
}
