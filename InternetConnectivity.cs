using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Peace_System
{
    internal class InternetConnectivity
    {
        public static bool checkConnectivity()
        {
            try
            {
                Random random = new Random();
                Ping myPing = new Ping();
                String[] host = { "google.com" };
                byte[] buffer = new byte[32];
                int timeout = 1000;
                int i = random.Next(host.Length);
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host[i], timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
