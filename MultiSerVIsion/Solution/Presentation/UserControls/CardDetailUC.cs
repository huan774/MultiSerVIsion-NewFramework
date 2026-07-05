using MultiSerVIsion.Solution.Domain.Entities;
using MultiSerVIsion.Solution.Domain.Entities.Configs;
using MultiSerVIsion.Solution.Presentation.Views;
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
    public partial class CardDetailUC : BaseViewUc,IDeviceDatailView
    {
        public event Action SaveConfigRequest;
        /* event Action ClearRequest;*/

        public CardDetailUC()
        {
            InitializeComponent();
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

                var cfg = device.MotionConfig ?? new MotionCardConnectConfig();
                nud_CardIndex.Value = cfg.CardIndex;
                nud_PulseFreq.Value = cfg.MaxPulseFreq;
                nud_AccTime.Value = cfg.AccDecTimeMs;
                cbx_EncoderMode.Text = cfg.EncoderMode;
                chk_AutoHomeOnStart.Checked = cfg.AutoHomeOnStart;
                chk_LimitEnable.Checked = cfg.LimitEnable;
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

                nud_CardIndex.Value = 0;
                nud_PulseEquivalent.Value = 100000;
                nud_AccTime.Value = 200;
                cbx_EncoderMode.SelectedIndex = 0;
                chk_AutoHomeOnStart.Checked = true;
                chk_LimitEnable.Checked = true;

            }
            finally
            {
                this.ResumeLayout(true);
            }
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
                DeviceName = lbl_DeviceName.Text,
                DeviceId = lbl_deviceID.Text,
                IpAddress = lbl_deviceID.Text,
                DeviceType = lbl_deviceType.Text,

                MotionConfig = new MotionCardConnectConfig
                {
                    CardIndex = (int)nud_CardIndex.Value,
                    MaxPulseFreq = (int)nud_PulseFreq.Value,
                    AccDecTimeMs = (int)nud_AccTime.Value,
                    EncoderMode = cbx_EncoderMode.Text,
                    LimitEnable = chk_LimitEnable.Checked,
                    AutoHomeOnStart = chk_AutoHomeOnStart.Checked,

                },
                PlcConfig=null,
                CameraConfig=null,
                
            };
           
        }
        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool ShowConfirmDialog(string msg)
        {
            return false;
        }
    }
}
