using System;
using System.Collections.Generic;
using Entities;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using FactoryEntities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Threading;
using Service;
using System.Configuration;

namespace WcfServiceAdvertiseMe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAdvertiseMe" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAdvertiseMe.svc or ServiceAdvertiseMe.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAdvertiseMe : IServiceAdvertiseMe
    {
        public string GetPointsByGPSPosition(string gpsPosition)
        {
            List<IPub> pubs = PubService.GetPointsByGPSPosition(ConfigurationManager.ConnectionStrings["advertisemeDb"].ConnectionString, "GetPointsByGPSPosition", gpsPosition);

            return JsonConvert.SerializeObject(pubs);
        }
    }
}
