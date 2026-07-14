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

namespace MultiSerVIsion.Solution.Domain.Entities
{
    public class CameraEntity
    {
        public Guid CameraId { get; }
        public CameraDeviceDto DeviceInfo { get; private  set; }

        public CameraConnectConfig ConnectParam { get;private set;  }
        public CameraStatus Status { get; private set; }
        public int sdkHandle { get; private set; } = -1;
        private readonly ICameraHardwareDriver _hardwareDriver;

        public CameraEntity(ICameraHardwareDriver hardwareDriver,CameraDeviceDto deviceInfo)
        {
            CameraId=Guid.NewGuid();
            _hardwareDriver = hardwareDriver;
            DeviceInfo = deviceInfo;
            Status = CameraStatus.Idle;
        }
        public void BindConnectParam(CameraConnectConfig param)
        {
            ConnectParam = param;
        }
        public OperationResult Connect()
        {
            if (Status != CameraStatus.Idle)
                return OperationResult.Fail($"当前状态{Status}，禁止重复登录");

            try
            {
                sdkHandle = _hardwareDriver.Login(ConnectParam);
                Status = CameraStatus.Connected;
                return OperationResult.Succes();

            }
            catch (Exception ex)
            {
                return OperationResult.Fail($"相机登录失败{ex.Message}");
            }
        }
        public OperationResult OpenStream()
        {
            if (Status != CameraStatus.Connected)
                return OperationResult.Fail("请先登录连接相机，在开启取流");

            try
            {
                 _hardwareDriver.OpenStream(sdkHandle);
                Status = CameraStatus.Connected;
                return OperationResult.Succes();

            }
            catch (Exception ex)
            {
                return OperationResult.Fail($"开启取流失败{ex.Message}");
            }
        }
        public OperationResult StopStream()
        {
            if (Status != CameraStatus.Streaming)
                return OperationResult.Fail("相机未开始取流，无需关闭");

            try
            {
                _hardwareDriver.CloseStream(sdkHandle);
                Status = CameraStatus.Connected;
                return OperationResult.Succes();

            }
            catch (Exception ex)
            {
                return OperationResult.Fail($"停止取流{ex.Message}");
            }
        }
        public OperationResult Disconnect()
        {
            if (sdkHandle <= 0)
            {
                Status = CameraStatus.Idle;
                return OperationResult.Succes();
            }
            try
            {
                StopStream();
                _hardwareDriver.Logout(sdkHandle);
                sdkHandle = -1;
                Status = CameraStatus.Idle;
                return OperationResult.Succes();

            }
            catch (Exception ex)
            {
                return OperationResult.Fail($"断开相机失败，{ex.Message}");
            }
        }
    }
}
