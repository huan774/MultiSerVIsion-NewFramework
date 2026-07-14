using MultiSerVIsion.Solution.Domain.Models;
using MultiSerVIsion.Solution.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Infrastructure.HiKHardware
{
    /*public class HikCameraHardwareDriver:ICameraHardwareDriver
    {
        public List<CameraDeviceDto> SearchAllCameraDevices()
        {
            List<CameraDeviceDto> result = new();
            var devList = HikDeviceHelper.EnumAllDevices();
            foreach (var dev in devList)
            {
                result.Add(new CameraDeviceDto
                {
                    IpAddress = dev.IP,
                    SerialNumber = dev.Serial,
                    ModelName = dev.Model
                });
            }
            return result;
        }

        public int Login(CameraConnectParam connectParam)
        {
            int handle = HikCamera.Login(connectParam.Ip, connectParam.Port, connectParam.UserName, connectParam.Password);
            if (handle <= 0)
            {
                int errCode = HikCamera.GetLastError();
                throw new Exception($"海康登录失败，错误码：{errCode}");
            }
            return handle;
        }

        public void OpenStream(int sdkHandle)
        {
            bool success = HikCamera.StartStream(sdkHandle);
            if (!success)
            {
                int errCode = HikCamera.GetLastError();
                throw new Exception($"开启取流失败，错误码：{errCode}");
            }
        }

        public void CloseStream(int sdkHandle)
        {
            HikCamera.StopStream(sdkHandle);
        }

        public void Logout(int sdkHandle)
        {
            HikCamera.Logout(sdkHandle);
        }
    }*/
}
