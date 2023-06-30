using UnityEngine;

public static class DeviceTypeHandler 
{
    public static bool TypeFinder()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
