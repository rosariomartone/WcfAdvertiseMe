using System;
using System.Collections.Generic;
using Entities;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceAdvertiseMe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAdvertiseMe" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAdvertiseMe.svc or ServiceAdvertiseMe.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAdvertiseMe : IServiceAdvertiseMe
    {
        public List<Pub> GetPointsByGPSPosition(string gpsPosition)
        {
            Pub pub = new Pub();
            List<Pub> pubs = new List<Pub>();
            pubs.Add(pub);

            return pubs;
        }
    }
}
