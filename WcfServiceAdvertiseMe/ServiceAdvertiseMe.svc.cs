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

namespace WcfServiceAdvertiseMe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAdvertiseMe" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAdvertiseMe.svc or ServiceAdvertiseMe.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAdvertiseMe : IServiceAdvertiseMe
    {
        public string GetPointsByGPSPosition(string gpsPosition)
        {
            IPub obj = FactoryPub.CreateInstance();
            obj.Name = "Rosario Martone";
            obj.Url = "https://github.com/rosariomartone";
            obj.Address = "166, 1 Newgate CR0 2FE Croydon (Surrey) UK";

            List<IPub> pubs = new List<IPub>();
            pubs.Add(obj);
            JsonSerializerSettings jss = new JsonSerializerSettings();

            DefaultContractResolver dcr = new DefaultContractResolver();
            dcr.DefaultMembersSearchFlags |= System.Reflection.BindingFlags.NonPublic;
            jss.ContractResolver = dcr;

            return JsonConvert.SerializeObject(pubs, jss);
        }
    }
}
