using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Domain.Models
{
    public class CameraDeviceDto
    {
        public string IpAddress { get; }
        public string SerialNumber { get; }
        public string ModelName { get; }

        
        public CameraDeviceDto(string ipAddress, string serialNumber, string modelName)
        {
            IpAddress = ipAddress;
            SerialNumber = serialNumber;
            ModelName = modelName;
        }
    }

}

