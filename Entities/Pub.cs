using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Pub : IPub
    {
        public string address;
        public string name;
        public string url;
        public string username;

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


        string IPub.Username
        {
            get
            {
                return username;
            }

            set
            {
                this.username = value;
            }
        }
    }
}
