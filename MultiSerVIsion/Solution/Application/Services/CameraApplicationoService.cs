using MultiSerVIsion.Solution.Application.Dtos;
using MultiSerVIsion.Solution.Domain.Entities.Configs;
using MultiSerVIsion.Solution.Domain.Enums;
using MultiSerVIsion.Solution.Domain.Models;
using MultiSerVIsion.Solution.Domain.Services;
using MultiSerVIsion.Solution.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Application.Services
{
    public class CameraApplicationoService
    {
        private readonly ICameraDeviceService _cameraDeviceService;
        public CameraApplicationoService(ICameraDeviceService cameraDeviceService)
        {
            _cameraDeviceService = cameraDeviceService;
        }
        public List<CameraUiDto> SearchCameraForUi()
        {
            List<CameraDeviceDto> domainList = _cameraDeviceService.SearchCameraDevices();
            return domainList.Select(d=>new CameraUiDto
            {
                Ip=d.IpAddress,
                Serial=d.SerialNumber,
                Model=d.ModelName
            }).ToList();
        }
        public OperationResult Selectcamera(CameraUiDto cameraUiDto, CameraConnectConfig LoginParam)
        {
            CameraDeviceDto domainDevice = new CameraDeviceDto(
                cameraUiDto.Ip, cameraUiDto.Serial, cameraUiDto.Model);
            return _cameraDeviceService.SelectCameraDevice(domainDevice, LoginParam);
            
        }
        public OperationResult ConnectCamera()
        {
            return _cameraDeviceService.ConnectCurrentCamera();
        }
        public OperationResult OpenCameraStream()
        {
            return _cameraDeviceService.OpenCurrentCameraStream();
        }

        public OperationResult CloseCameraStream()
        {
            return _cameraDeviceService.CloseCurrentCameraStream();
        }
        
        public OperationResult DisconnectCamera()
        {
            return _cameraDeviceService.DisconnectCurrentCamera();
        }
        public CameraStatus GetCurrentCameraStatus()
        {
            return _cameraDeviceService.GetCurrentCameraStatus();
        }

    }
}
