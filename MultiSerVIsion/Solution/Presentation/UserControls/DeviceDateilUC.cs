using MultiSerVIsion.Solution.Domain.Entities;
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
    public partial class DeviceDateilUC : BaseViewUc,IDeviceDatailView
    {
        public event Action<string, Dictionary<string, string>> OnDeviceConfigSave;
        private string _currentDeviceId;

        public event Action SaveConfigRequest;
        public event Action ClearRequest;
        public DeviceDateilUC()
        {
            InitializeComponent();
            this.Dock= DockStyle.Fill;
           /* btn_SaveConfig.Click += Btn_SaveConfig_Click;*/
        }

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfigRequest?.Invoke();
        }
        public void LoadDeviceData(DeviceEntity device)
        {
            txt_DeviceName.Text = device.DeviceName;
            txt_Ip.Text = device.IpAddress;
            cbx_Protocol.Text=device.DeviceType.ToString();
           /* chk_Enable.CheckedItems = device.IsEnable;*/
        }
        public void ClearPanel()
        {
            txt_DeviceName.Clear();
            txt_Ip.Clear();
            /*cbx_Protocol.SelectedIndex = 0;*/
            /*chk_Enable.CheckedItems = false;*/
            SetEditDisable();
        }
        public void SetEditDisable()
        {
            txt_DeviceName.ReadOnly = true;
            txt_Ip.ReadOnly = true;
            cbx_Protocol.Enabled = false;
            btn_SaveConfig.Enabled = false;
        }
        public void SetEditEnable()
        {
            txt_DeviceName.ReadOnly=false;
            txt_Ip.ReadOnly=false;
            cbx_Protocol.Enabled=true;
            btn_SaveConfig.Enabled=true;
        }
        public DeviceEntity GetEditInput()
        {
            return new DeviceEntity
            {
                DeviceId = txt_DeviceName.Text.Trim(),
                IpAddress = txt_Ip.Text.Trim(),
                DeviceType = cbx_Protocol.Text.Trim(),
             /*   IsEnable = chk_Enable.Chrcked*/
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
