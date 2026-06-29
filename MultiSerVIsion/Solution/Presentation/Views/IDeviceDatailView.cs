using MultiSerVIsion.Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Presentation.Views
{
    public interface IDeviceDatailView
    {
        event Action SaveConfigRequest;
       /* event Action ClearRequest;*/
        void LoadDeviceData(DeviceEntity device);
        void ClearPanel();
        void SetEditDisable();

        void SetEditEnable();

        DeviceEntity GetEditInput();
        void ShowMessage(string msg);
        bool ShowConfirmDialog(string msg);


    }
}
