using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pub : IPub
    {
        private string address;
        private string name;
        private string url;

        string IPub.Address
        {
            get
            {
                return address;
            }

            set
            {
                this.address=value;
            }
        }

        string IPub.Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name=value;
            }
        }

        string IPub.Url
        {
            get
            {
                return url;
            }

            set
            {
                this.url=value;
            }
        }
    }
}
