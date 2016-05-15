using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Entities;

namespace FactoryEntities
{
    public class FactoryPub
    {
        static public IPub CreateInstance()
        {
            IUnityContainer _container = new UnityContainer();
            _container.RegisterType(typeof(IPub), typeof(Pub));
            IPub obj = _container.Resolve<IPub>();
            return obj;
        }
    }
}
