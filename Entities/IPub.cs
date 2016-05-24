using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IPub
    {
        string Name
        {
            get;
            set;
        }

        string Address
        {
            get;
            set;
        }

        string Url
        {
            get;
            set;
        }


        string Username
        {
            get;
            set;
        }
    }
}
