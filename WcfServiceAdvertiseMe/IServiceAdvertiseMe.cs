using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Entities;
using System.Text;

namespace WcfServiceAdvertiseMe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceAdvertiseMe" in both code and config file together.
    [ServiceContract]
    public interface IServiceAdvertiseMe
    {
        [OperationContract]
        [WebInvoke(Method ="GET", UriTemplate = "/PointsByGPSPosition/{gpsPosition}", RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.Wrapped)]
        List<IPub> GetPointsByGPSPosition(string gpsPosition);
    }
}
