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
    public partial class PlcDetailUC : BaseViewUc,IDeviceDatailView
    {
        public event Action SaveConfigRequest;
        /* event Action ClearRequest;*/
        public PlcDetailUC()
        {
            InitializeComponent();
            cbx_PlcProtocol.Items.AddRange(new[] { "ModbusTcp", "ModbusRtu" });
            cbx_PlcProtocol.SelectedIndex = 0;
            cbx_PlcBaudRate.Items.AddRange(new[] { "4800","9600" ,"14400","19200"});
            cbx_PlcBaudRate.SelectedIndex = 1;
           /* panelBaud.Visible = false;*/
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

                var cfg = device.PlcConfig ?? new PlcconnectConfig();
                nud_Port.Value = cfg.Port;
                nud_PlcStationNo.Value=cfg.StationNo;
                nud_PlcTimeout.Value = cfg.ReadTimeoutMs;
                cbx_PlcProtocol.Text = cfg.ProtocolType;
                cbx_PlcBaudRate.Text=cfg.BaudRate;
                txt_PlcIP.Text = cfg.IP;
                
               
            }
            finally
            { 
                this.ResumeLayout(); 
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

                nud_Port.Value = 502;
                nud_PlcStationNo.Value = 1;
                nud_PlcTimeout.Value = 1000;
                cbx_PlcProtocol.SelectedIndex = 0;
                cbx_PlcBaudRate.SelectedIndex = 1;
                txt_PlcIP.Text = "127.0.0.0";
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

                PlcConfig = new PlcconnectConfig
                {
                    Port = (int)nud_Port.Value,
                    StationNo = (int)nud_PlcStationNo.Value,
                    ReadTimeoutMs = (int)nud_PlcTimeout.Value,
                    ProtocolType = cbx_PlcProtocol.Text,
                    BaudRate = cbx_PlcBaudRate.Text,
                },
                CameraConfig = null,
                MotionConfig = null,
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

        private void btn_ClearConfig_Click(object sender, EventArgs e)
        {
           /* ClearRequest?.Invoke();*/
        }

        private void cbx_PlcProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* panelBaud.Visible = cbxProtocolType.Text == "ModbusRtu";*/
        }
    }
}
