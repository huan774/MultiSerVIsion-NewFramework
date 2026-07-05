using MultiSerVIsion.Solution.Application.Dtos;
using MultiSerVIsion.Solution.Domain.Entities;
/*using MultiSerVIsion.Solution.Domain.Models;*/
using MultiSerVIsion.Solution.Domain.Repositories;
using MultiSerVIsion.Solution.Domain.Services;
using MultiSerVIsion.Solution.Shared.Exceptions;
using MultiSerVIsion.Solution.Shared.Helpers;
using MultiSerVIsion.Solution.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Application
{
    public class DeviceAppService: IDeviceAppService
    {
        private readonly IDeviceRepository _repo;
        private readonly IDeviceDomainSerivce _domainService;

        public DeviceAppService(IDeviceRepository repo, IDeviceDomainSerivce domainService)
        {
            _repo = repo;
            _domainService = domainService;
        }
        public OperationResult<DeviceEntity> CopyDevice(string soureDeviceId)
        {
            try
            {
                var source = _repo.GetById(soureDeviceId);
                var copyCheck = _domainService.CanCopyDevice(source);
                if (!copyCheck.IsValid)
                    return OperationResult<DeviceEntity>.Fail(copyCheck.Message);

                var newDevice = _domainService.CloneDevice(source);
                _repo.Add(newDevice);

                string groupTag = _repo.GetGroupTag(soureDeviceId);
                return OperationResult<DeviceEntity>.Succes(newDevice, groupTag);
            }
            catch (DeviceNotFoundException ex)
            {
                LogHelper.Error("复制设备失败，源设备不存在", ex);
                return OperationResult<DeviceEntity>.Fail(ex.Message);
            }
            catch (DeviceDuplicateIdException ex)
            {
                LogHelper.Error("复制设备ID冲突", ex);
                return OperationResult<DeviceEntity>.Fail(ex.Message);
            }
            catch (StorageIoException ex)
            {
                LogHelper.Error("复制设备存储异常", ex);
                return OperationResult<DeviceEntity>.Fail($"本地存储异常：{ex.Message}");
            }
            catch (Exception ex)
            {
                LogHelper.Error("复制设备未知异常", ex);
                return OperationResult<DeviceEntity>.Fail($"系统异常：{ex.Message}");
            }
        }

        public OperationResult<DeviceEntity> CreateDevice(DeviceCreateInput input)
        {
            try
            {
                var entity = new DeviceEntity
                {
                    DeviceId = Guid.NewGuid().ToString("N"),
                    GroupTage = input.GroupTag,
                    DeviceName = input.DeviceName,
                    IpAddress = input.IpAddress,
                    DeviceType = input.DeviceType,
                    IsEnable = input.IsEnable,
                };
                var validate = _domainService.ValidateDeviceEntity(entity);
                if (!validate.IsValid)
                    return OperationResult<DeviceEntity>.Fail(validate.Message);

                _repo.Add(entity);
                return OperationResult<DeviceEntity>.Succes(entity, entity.GroupTage);
            
            }catch(DeviceDuplicateIdException ex)
            {
                LogHelper.Error("新增设备ID重复", ex);
                return OperationResult<DeviceEntity>.Fail(ex.Message);
            }
            catch (StorageIoException ex)
            {
                LogHelper.Error("存储失败", ex);
                return OperationResult<DeviceEntity>.Fail($"本地存储异常：{ex.Message}");
            }
            catch (Exception ex)
            {
                LogHelper.Error("新增设备未知异常", ex);
                return OperationResult<DeviceEntity>.Fail($"系统异常：{ex.Message}");
            }
        }
        
        public OperationResult<bool> DeleteDevice(string devId) 
        {
            try
            {
                bool success = _repo.Remove(devId);
                return OperationResult<bool>.Succes(success);

            }catch (DeviceDuplicateIdException ex)
            {
                LogHelper.Error("删除设备不存在", ex);
                return OperationResult<bool>.Fail(ex.Message);
            }
            catch (StorageIoException ex)
            {
                LogHelper.Error("删除存储异常", ex);
                return OperationResult<bool>.Fail($"本地存储异常：{ex.Message}");
            }
            catch (Exception ex)
            {
                LogHelper.Error("删除设备未知异常", ex);
                return OperationResult<bool>.Fail($"系统异常：{ex.Message}");
            }
        }
        public OperationResult<bool> ToggleDeviceEnable(string devId) 
        {
            try
            {
                var dveice = _repo.GetById(devId);
                var check = _domainService.CheckToggleEnable(dveice);
                if (!check.IsValid)
                    return OperationResult<bool>.Fail(check.Message);

                _repo.Update(dveice);
                return OperationResult<bool>.Succes(true);

            }catch (DeviceNotFoundException ex)
            {
                LogHelper.Error("启停设备不存在", ex);
                return OperationResult<bool>.Fail(ex.Message);
            }
            catch (StorageIoException ex)
            {
                LogHelper.Error("启停存储异常", ex);
                return OperationResult<bool>.Fail($"本地存储异常：{ex.Message}");
            }
            catch (Exception ex)
            {
                LogHelper.Error("启停设备未知异常", ex);
                return OperationResult<bool>.Fail($"系统异常：{ex.Message}");
            }
        }
        public OperationResult<List<DeviceEntity>> GetDeviceByGroup(string groupTag) 
        { 
           try
           {
                var list = _repo.GetByGroup(groupTag);
                return OperationResult<List<DeviceEntity>>.Succes(list);
            }
            catch (StorageIoException ex)
            {
                LogHelper.Error("分组查询存储异常", ex);
                return OperationResult<List<DeviceEntity>>.Fail($"本地存储异常：{ex.Message}");
            }
        }
        public OperationResult<List<DeviceEntity>> GetAllDevices()
        {
            try
            {
                var list = _repo.GetAll();
                return OperationResult<List<DeviceEntity>>.Succes(list);
            }
            catch(StorageIoException ex)
            {
                LogHelper.Error("全局查询储存异常",ex);
                return OperationResult<List<DeviceEntity>>.Fail($"本地存储异常：{ex.Message}");
            }
        }
        public OperationResult<DeviceEntity> UpdataDevice(DeviceUpdateIput input)
        {
            try
            {
                var target = _repo.GetById(input.DeviceId);
                if (target == null)
                    return OperationResult< DeviceEntity>.Fail($"设备{input.DeviceName}不存在");

                target.DeviceId = input.DeviceId;
                target.DeviceName = input.DeviceName;
                target.IpAddress=input.IpAddress;
                target.DeviceType = input.DeviceType;
                target.IsEnable=input.IsEnable;

                target.PlcConfig = input.PlcConfig;
                target.MotionConfig = input.MotionCardConfig;
                target.CameraConfig = input.CameraConfig;

                _repo.Update(target);
                return OperationResult<DeviceEntity>.Succes(target, target.GroupTage);
            }
            catch (DeviceNotFoundException ex)
            {
                LogHelper.Error("更新设备不存在", ex);
                return OperationResult<DeviceEntity>.Fail(ex.Message);
            }
            catch (StorageIoException ex)
            {
                LogHelper.Error("更新存储异常", ex);
                return OperationResult<DeviceEntity>.Fail($"本地存储异常：{ex.Message}");
            }
            catch (Exception ex)
            {
                LogHelper.Error("更新设备未知异常", ex);
                return OperationResult<DeviceEntity>.Fail($"系统异常：{ex.Message}");
            }
        }
        public OperationResult<DeviceEntity> GetDeviceById(string devId)
        {
            try
            {
                var data = _repo.GetById(devId);
                return OperationResult<DeviceEntity>.Succes(data);

            }
            catch( StorageIoException ex)
            {
                LogHelper.Error("查询设备存储异常", ex);
                return OperationResult<DeviceEntity>.Fail($"本地存储异常：{ex.Message}");

            }
        }
    }
}
