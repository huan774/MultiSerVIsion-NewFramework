using MultiSerVIsion.Solution.Application.Dtos;
using MultiSerVIsion.Solution.Domain.Entities;
using MultiSerVIsion.Solution.Domain.Entities.Configs;
using MultiSerVIsion.Solution.Domain.Enums;
using MultiSerVIsion.Solution.Domain.Models;
using MultiSerVIsion.Solution.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Services
{
    public interface ICameraDeviceService
    {
        List<CameraDeviceDto> SearchCameraDevices();
        OperationResult SelectCameraDevice(CameraDeviceDto deviceInfo, CameraConnectConfig config);

        OperationResult ConnectCurrentCamera();

        OperationResult OpenCurrentCameraStream();

        OperationResult CloseCurrentCameraStream();

        OperationResult DisconnectCurrentCamera();

        CameraStatus GetCurrentCameraStatus();
    }
}
