using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Presentation.Views
{
    public interface IDeviceTreeView
    {
        event Action AddDeviceRequest;
        event Action<string> CopyDeviceRequest;
        event Action<string> RemoveDeviceRequest;
        event Action<string> ToggleDeviceEnableRequest;
        event Action<string> DeviceNodeSelected;
        event Action DeviceNodeUnSelect;

        void AddTreeNode(string groupTag, string devId, string devName);
        void RemoveTreeNode(string devId);
        void ClearSelectNode();
        void RefreshDeviceStatusIcon();

        bool ShowConfirmDialog(string message);
        void ShowMessage(string msg);
        string GetRightClickGroupKey();
    }
}
