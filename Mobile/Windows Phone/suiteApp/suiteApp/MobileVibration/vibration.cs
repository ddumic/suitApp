using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Devices;
using Windows.Phone.Devices.Notification;

namespace suiteApp
{
    class vibration
    {
        public static void mobileVibration()
        {
            VibrationDevice testVibrationDevice = VibrationDevice.GetDefault();
            testVibrationDevice.Vibrate(TimeSpan.FromSeconds(0.2));
        }
    }
}
