using MultiSerVIsion.Solution.Application;
using MultiSerVIsion.Solution.Application.Dtos;
using MultiSerVIsion.Solution.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MultiSerVIsion.Solution.Presentation.Presenter
{
    public class DeviceDetailPresenter
    {
        private readonly IDeviceDatailView _datailView;
        private readonly IDeviceAppService _appService;
        private string _currentEditDevId = string.Empty;
        public DeviceDetailPresenter(IDeviceDatailView datailView, IDeviceAppService appService)
        {
            _datailView = datailView;
            _appService = appService;
           
            _datailView.SaveConfigRequest += OnSaveConfig;
           /* _datailView.ClearRequest += OnClearEdit;*/
        }
        public void LoadDevice(string devId)
        {
            _currentEditDevId= devId;
             var res = _appService.GetDeviceById(devId);
             if (!res.Success|| res.Data == null)
             {
                 _datailView.ShowMessage("设备加载失败:"+res.Message);
                 ClearEdit();
                 return;
             }
             /*_currentEditDevId = devId;*/
             _datailView.LoadDeviceData(res.Data);

        }
        public void ClearEdit()
        {
            _currentEditDevId = string.Empty;
            _datailView.ClearPanel();
        }
        private void OnSaveConfig()
        {
            if (string.IsNullOrEmpty(_currentEditDevId))
            {
                _datailView.ShowMessage("未选中设备，无法保存");
                return;
            }
            if (!_datailView.ShowConfirmDialog("确认保存当前设备？")) return;
           
            var editData = _datailView.GetEditInput();

            DeviceUpdateIput input = new DeviceUpdateIput
            {
                DeviceId = _currentEditDevId,
                DeviceName = editData.DeviceName,
                IpAddress = editData.IpAddress,
                DeviceType = editData.DeviceType,
                IsEnable = editData.IsEnable,
            };

           /* editData.DeviceId = _currentEditDevId;*/
            var saveResult=_appService.UpdataDevice(input);
            if (saveResult.Success)
            {
                _datailView.ShowMessage("保存成功");
            }
            else
            {
                _datailView.ShowMessage(saveResult.Message);
            }
        }
    }
}
