using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Entities.Configs
{
    public class PlcconnectConfig
    {
        public string IP { get; set; } = "127.0.0.0";
        public int Port { get; set; } = 502;               
        public int StationNo { get; set; } = 1;             
        public int ReadTimeoutMs { get; set; } = 1000;     
        public string ProtocolType { get; set; } = "ModbusTcp"; 
        public string BaudRate { get; set; } = "9600";           
        public int WriteRetryCount { get; set; } = 2;
    }
    public class PlcRuntimeParam
    {
        public int PollIntervalMs { get; set; } = 100;      // 实时轮询间隔
        public bool IsAutoPoll { get; set; } = false;       // 是否自动周期采集
        public int TempReadOffset { get; set; } = 0;        // 临时读取寄存器偏移
        public int TempReadLength { get; set; } = 10;       // 临时读取寄存器长度
        public bool TempIgnoreTimeout { get; set; } = false;// 临时忽略超时限制
    }
}
