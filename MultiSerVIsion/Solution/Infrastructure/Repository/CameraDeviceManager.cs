using MultiSerVIsion.Solution.Domain.Entities;
using MultiSerVIsion.Solution.Domain.Models;
using MultiSerVIsion.Solution.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Infrastructure.Repository
{
    public class CameraDeviceManager : ICameraDeviceManager
    {
        private readonly ICameraHardwareDriver _cameraDriver;
        private CameraEntity _activeCamera;

        public CameraDeviceManager(ICameraHardwareDriver cameraDriver)
        {
            _cameraDriver = cameraDriver;
        }
        public List<CameraDeviceDto> RefreshCameraDeviceList()
        {
            return _cameraDriver.SerchAllCameraDevice();
        }
        public CameraEntity CreateCameraEntity(CameraDeviceDto deviceInfo)
        {
            return new CameraEntity(_cameraDriver, deviceInfo);
        }
        public CameraEntity GetCurrtActiveCamera() => _activeCamera;

        public void SetCurrentActiveCamera(CameraEntity camera)
        {
            _activeCamera?.Disconnect();
            _activeCamera = camera;
        }
        public void ReleaseAllCamera()
        {
            _activeCamera?.Disconnect();
            _activeCamera = null;
        }

    }

}
