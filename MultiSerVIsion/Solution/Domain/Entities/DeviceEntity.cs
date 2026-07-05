using MultiSerVIsion.Solution.Domain.Entities.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MultiSerVIsion.Solution.Domain.Entities
{
    public class DeviceEntity
    {
        public string DeviceId {  get; set; }
        public string DeviceName { get; set; }
        public string GroupTage {  get; set; }
        public string IpAddress {  get; set; }
        public string DeviceType {  get; set; }
        public bool IsEnable {  get; set; }
      /*  public Dictionary<string, string> ExtParams { get; set; } = new Dictionary<string, string>();
        public  static class ExtParamHelper
        {
            public static int GetValueOrDefault(this Dictionary<string, string> dict, string key, int defaultValue)
            {
                if (dict.TryGetValue(key, out var val) && int.TryParse(val, out int num))
                    return num;
                return defaultValue;
            }
        }*/

        public PlcconnectConfig PlcConfig {  get; set; }
        public CameraConnectConfig CameraConfig {  get; set; }
        public MotionCardConnectConfig MotionConfig { get; set; }
        public DeviceEntity ShallowClone()
        {
            return new DeviceEntity
            {
                DeviceId =this.DeviceId,
                GroupTage=this.GroupTage,
                DeviceName=this.DeviceName,
                IpAddress=this.IpAddress,
                DeviceType=this.DeviceType,
                IsEnable=this.IsEnable,
            };

        }
        public Shared.Models.ValidationResult SelfValidate()
        {
            if (string.IsNullOrWhiteSpace(DeviceName) || DeviceName.Length > 64)
                return Shared.Models.ValidationResult.Failure("设备长度不能为空且长度≤64");
            if (!CheckIpFormat(IpAddress))
                return Shared.Models.ValidationResult.Failure("IP格式非法");
            if (string.IsNullOrWhiteSpace(GroupTage))
                return Shared.Models.ValidationResult.Failure("必须选择设备分组");
            return Shared.Models.ValidationResult.Success();

        }
        private bool CheckIpFormat(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip)) return false;
            var arr = ip.Split('.');
            if (arr.Length != 4) return false;
            return arr.All(x => byte.TryParse(x, out var num) && num <= 255);
        }
    }
}
