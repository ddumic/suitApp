using Microsoft.Phone.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiteApp
{
    public class checkInternet
    {
        public static bool checkInternetConnection()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                return true;
            }
            return false;
        }
    }
}
