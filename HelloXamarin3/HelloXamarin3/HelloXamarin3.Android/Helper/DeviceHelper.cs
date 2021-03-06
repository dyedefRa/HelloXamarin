using HelloXamarin3.Helper;
using HelloXamarin3.Droid.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace HelloXamarin3.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "HelloXamarin3.Android ortamı çalıştı";
        }
    }
}