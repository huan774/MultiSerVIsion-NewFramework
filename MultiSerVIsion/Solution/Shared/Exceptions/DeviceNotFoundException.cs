using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Shared.Exceptions
{
    public class DeviceNotFoundException:Exception
    {
        public DeviceNotFoundException(string devId)
            : base($"设备ID【{devId}】不存在") { }
    }
    public class DeviceDuplicateIdException : Exception
    {
        public DeviceDuplicateIdException(string  devId)
            : base($"设备ID【{devId}】已存在，不可重复添加") { }
    }
    public class StorageIoException : Exception
    {
        public StorageIoException(string path, string msg)
            : base($"储存文件[{path}]操作失败：{msg}") { }
    }

}
