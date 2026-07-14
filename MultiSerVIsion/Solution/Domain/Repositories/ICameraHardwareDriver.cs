using MultiSerVIsion.Solution.Domain.Entities.Configs;
using MultiSerVIsion.Solution.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Repositories
{
    public interface ICameraHardwareDriver
    {
        List<CameraDeviceDto> SerchAllCameraDevice();
        int Login(CameraConnectConfig connectParam);
        void OpenStream(int sdkHandle);
        void CloseStream(int sdkHandle);
        void Logout(int sdkHandle);
    }
}
