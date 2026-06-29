using MultiSerVIsion.Solution.Domain.Entities;
using MultiSerVIsion.Solution.Domain.Repositories;
using MultiSerVIsion.Solution.Shared.Helpers;
using MvCameraControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MultiSerVIsion.Solution.Infrastructure.Repository
{
    public class DeviceRepository: IDeviceRepository
    {
        private readonly string _storagePath;
       
        public DeviceRepository()
        {
            _storagePath = Path.Combine(
           AppDomain.CurrentDomain.BaseDirectory,
           Shared.GlobalConst.AppDataFolder,
           Shared.GlobalConst.DeviceJsonFIleName
           );

            if ( !Directory.Exists(_storagePath)){
                FileloHelper.WriteJsonFile(_storagePath, new List<DeviceEntity>(), JsonConfigHelper.Default);
            }
        }
        private List<DeviceEntity> ReadAll()
        {
            return FileloHelper.ReadJsonFile<List<DeviceEntity>>(_storagePath, JsonConfigHelper.Default);
        }

        private void WriteAll(List<DeviceEntity> list)
        {
            FileloHelper.WriteJsonFile(_storagePath, list, JsonConfigHelper.Default);
        }

        public DeviceEntity GetById(string devId)
        {
            var list = ReadAll();
            return list.FirstOrDefault(d=>d.DeviceId == devId);
        }
       
        public void Update(DeviceEntity deviceEntity)
        {
            var list = ReadAll();
            var index=list.FindIndex(d=>d.DeviceId==deviceEntity.DeviceId);
            if (index == -1)
                throw new KeyNotFoundException($"未找到设备{deviceEntity.DeviceId},无法更新");

            list[index]=deviceEntity;
            WriteAll(list);
            LogHelper.Info($"更新设备配置：{deviceEntity.DeviceName}({deviceEntity.DeviceId})");

        }
        public void Add(DeviceEntity deviceEntity)
        {
            var list = ReadAll();
            if (list.Any(d => d.DeviceId == deviceEntity.DeviceId))
                throw new InvalidOperationException($"设备ID{deviceEntity.DeviceId}");
              
            list.Add(deviceEntity);
            WriteAll(list);
            LogHelper.Info($"新增设备成功：{deviceEntity.DeviceName}({deviceEntity.DeviceId})");

        }
        public bool Remove(string deviceEntity) 
        {
            var list = ReadAll();
            var target = list.FirstOrDefault(d => d.DeviceId == deviceEntity);
            if (target == null) return false;

            list.Remove(target);
            WriteAll(list);
            LogHelper.Info($"删除设备成功：{target.DeviceName}({deviceEntity})");

            return true;
        }
      
        public List<DeviceEntity> GetAll() { return ReadAll(); }

        public string GetGroupTag(string devId)
        {
            var dev = GetById(devId);
            return dev.GroupTage ?? string.Empty;
        }
        public List<DeviceEntity> GetByGroup(string groupId)
        {
            var list = ReadAll();
            return list.Where(d=>d.GroupTage==groupId).ToList();
        }
    }
}
