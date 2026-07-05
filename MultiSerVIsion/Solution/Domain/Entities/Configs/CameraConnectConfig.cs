using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Entities.Configs
{
    public class CameraConnectConfig
    {
        public int Port { get; set; } = 3956;               
        public int DefaultExposureUs { get; set; } = 5000; 
        public int DefaultGain { get; set; } = 8;          
        public string TriggerDefaultMode { get; set; } = "Soft";
        public string CameraType { get; set; } = "GigE";
        public int TriggerChannel { get; set; } = 1;      
        public bool AutoExposureDefault { get; set; } = false; 
        public int ImageWidth { get; set; } = 1280;        
        public int ImageHeight { get; set; } = 960;

    }
    public class CameraRuntimeParam
    {
        public int RealTimeExposureUs { get; set; }         // 实时拖动曝光
        public int RealTimeGain { get; set; }              // 实时拖动增益
        public string TempTriggerMode { get; set; }         // 临时切换触发模式
        public bool TempAutoExposure { get; set; }         // 临时开启自动曝光
        public Rectangle TempRoi { get; set; }             // 临时裁剪ROI区域
        public bool IsContinuousGrab { get; set; } = false; // 连续采集开关
    }
}
