using MultiSerVIsion.Solution.Application.Dtos;
using MultiSerVIsion.Solution.Domain.Entities;
using MultiSerVIsion.Solution.Domain.Entities.Configs;
using MultiSerVIsion.Solution.Domain.Enums;
using MultiSerVIsion.Solution.Domain.Models;
using MultiSerVIsion.Solution.Domain.Repositories;
using MultiSerVIsion.Solution.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Services
{
    public class CameraDomainService:ICameraDeviceService
    {
        private readonly ICameraDeviceManager _cameraManager;
        public CameraDomainService(ICameraDeviceManager cameraManager)
        {
            _cameraManager = cameraManager;
        }
        public List<CameraDeviceDto> SearchCameraDevices()
        {
            return _cameraManager.RefreshCameraDeviceList();
        }
        public OperationResult SelectCameraDevice(CameraDeviceDto deviceInfo, CameraConnectConfig config)
        {
            CameraEntity camera=_cameraManager.CreateCameraEntity(deviceInfo);
            camera.BindConnectParam(config);
            _cameraManager.SetCurrentActiveCamera(camera);
            return OperationResult.Succes();
        }
        public OperationResult ConnectCurrentCamera()
        {
            CameraEntity camera = _cameraManager.GetCurrtActiveCamera();
            if (camera == null)
                return OperationResult.Fail("未选中任何相机设备");
            return camera.Connect();
        }
        public OperationResult OpenCurrentCameraStream()
        {
            CameraEntity camera =_cameraManager.GetCurrtActiveCamera();
            if (camera == null)
                return OperationResult.Fail("未选中任何相机设备");
            return camera.OpenStream();
        }
        public OperationResult CloseCurrentCameraStream()
        {
            CameraEntity camera=_cameraManager.GetCurrtActiveCamera();
            if (camera == null)
                return OperationResult.Fail("未选中任何相机设备");
            return camera.StopStream();
        }

        public OperationResult DisconnectCurrentCamera()
        {
            CameraEntity camera = _cameraManager.GetCurrtActiveCamera();
            if (camera == null)
                return OperationResult.Fail("未选中任何相机设备");
            return camera.Disconnect();
        }

        public CameraStatus GetCurrentCameraStatus()
        {
            CameraEntity camera = _cameraManager.GetCurrtActiveCamera();
            return camera?.Status ?? CameraStatus.Idle;
        }
    }
}
