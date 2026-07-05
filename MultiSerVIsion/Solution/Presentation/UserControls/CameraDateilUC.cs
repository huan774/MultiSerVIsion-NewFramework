using MultiSerVIsion.Solution.Domain.Entities;
using MultiSerVIsion.Solution.Domain.Entities.Configs;
using MultiSerVIsion.Solution.Presentation.Views;
using MvCameraControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    public partial class CameraDateilUC : BaseViewUc,IDeviceDatailView
    {
        public event Action<string, Dictionary<string, string>> OnDeviceConfigSave;
        private string _currentDeviceId;

        public event Action SaveConfigRequest;
        public event Action ClearRequest;
        public CameraDateilUC()
        {
            InitializeComponent();
            cbx_CamTrigger.Items.AddRange(new[] { "Soft", "hard" });
            cbx_CamTrigger.SelectedIndex = 0;
            cbx_CamType.Items.AddRange(new[] { "USB", "GigE", "Camera Link", "CoaXPress" });
            cbx_CamType.SelectedIndex = 1;
          /*  btn_SaveConfig.Click += Btn_SaveConfig_Click;*/
        }

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfigRequest?.Invoke();
        }
        public void LoadDeviceData(DeviceEntity device)
        {
            this.SuspendLayout();
            try
            {
                lbl_deviceID.Text = device.DeviceId;
                lbl_DeviceName.Text = device.DeviceName;
                lbl_deviceType.Text = device.DeviceType;
                lbl_deviceStuate.Text = "未连接";

                var cfg = device.CameraConfig ?? new CameraConnectConfig();
                num_CamPort.Value = cfg.Port;
                num_CamExposureUs.Value = cfg.DefaultExposureUs;
                nud_CamChannel.Value = cfg.TriggerChannel;
                num_CamGiain.Value = cfg.DefaultGain;
                cbx_CamTrigger.Text = cfg.TriggerDefaultMode;
                cbx_CamType.Text = cfg.CameraType;
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }
        public void ClearPanel()
        {
            this.SuspendLayout();
            try
            {
                lbl_deviceID.Text = "未加载设备";
                lbl_DeviceName.Text = string.Empty;
                lbl_deviceType.Text = string.Empty;
                lbl_deviceStuate.Text = string.Empty;

                num_CamPort.Value = 3956;
                num_CamExposureUs.Value = 5000;
                num_CamGiain.Value = 8;
                cbx_CamTrigger.SelectedIndex = 0;
                cbx_CamType.SelectedIndex = 1;
                nud_CamChannel.Value = 1;
                chk_AutoExposureDefault.Checked = false;

            }
            finally
            {
                this.ResumeLayout(false);
            }
            SetEditDisable();
        }
        public void SetEditDisable()
        {
          
        }
        public void SetEditEnable()
        {
            
        }
        public DeviceEntity GetEditInput()
        {
            return new DeviceEntity
            {
                DeviceName=lbl_DeviceName.Text,
                DeviceId = lbl_deviceID.Text,
                IpAddress = lbl_deviceID.Text,
                DeviceType = lbl_deviceType.Text,
                /*IsEnable = chkIsEnable.Checked,*/

                CameraConfig = new CameraConnectConfig
                {
                    Port = (int)num_CamPort.Value,
                    DefaultExposureUs = (int)num_CamExposureUs.Value,
                    DefaultGain = (int)num_CamGiain.Value,
                    TriggerDefaultMode = cbx_CamTrigger.Text,
                    TriggerChannel = (int)nud_CamChannel.Value,
                    AutoExposureDefault = chk_AutoExposureDefault.Checked,

                },
                PlcConfig = null,
                MotionConfig = null,
            };
            
        }
        public void ShowMessage(string message) { MessageBox.Show(this,message); }
        public bool ShowConfirmDialog(string  message) { return MessageBox.Show(this,message,"提示",MessageBoxButtons.YesNo)==DialogResult.Yes; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearRequest?.Invoke();
        }
       
    }
}
