using MultiSerVIsion.Solution.Domain.Entities;
using MultiSerVIsion.Solution.Domain.Entities.Configs;
using MultiSerVIsion.Solution.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Repositories
{
     public interface ICameraDeviceManager
    {
        List<CameraDeviceDto> RefreshCameraDeviceList();

        CameraEntity CreateCameraEntity(CameraDeviceDto deviceInfo);
        CameraEntity GetCurrtActiveCamera();
        void SetCurrentActiveCamera(CameraEntity camera);
        void ReleaseAllCamera();
    }
}
