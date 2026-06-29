using MultiSerVIsion.Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Repositories
{
    public interface IDeviceRepository
    {
        DeviceEntity GetById(string devId);

        void Add(DeviceEntity device);

        bool Remove(string  devId);

        void Update(DeviceEntity device);

        string GetGroupTag(string devId);
        List<DeviceEntity> GetByGroup(string groupId);
        List<DeviceEntity> GetAll();
    }
}
