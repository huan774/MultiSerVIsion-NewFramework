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
    public partial class DeviceDateilUC : BaseViewUc
    {
        public event Action<string, Dictionary<string, string>> OnDeviceConfigSave;
        private string _currentDeviceId;
        public DeviceDateilUC()
        {
            InitializeComponent();
            btn_SaveConfig.Click += Btn_SaveConfig_Click;
        }
        public void LoadDeviceInfo(string deviceId, Dictionary<string, string> config)
        {
            _currentDeviceId = deviceId;
            txt_DeviceName.Text = config["Name"];
            txt_Ip.Text = config["Ip"];
            cbx_Protocol.Text = config["Protocol"];
           /* chk_Enable.Checked = config["IsEnable"] = "1";*/

        }
        private void Btn_SaveConfig_Click(object sender, EventArgs e)
        {
            var cfg = new Dictionary<string, string>()
            {
                ["Name"] = txt_DeviceName.Text,
                ["IP"] = txt_Ip.Text,
                ["Protocol"] = cbx_Protocol.Text,
              /*  ["IsEnable"] = chk_Enable.Checked ? "1" : "0"*/
            };
            OnDeviceConfigSave?.Invoke(_currentDeviceId, cfg);
        }
        public override void OnViewShow()
        {
            base.OnViewShow();
        }
        public override void SetUIPlaceholder()
        {
            txt_DeviceName.Clear();
            txt_Ip.Clear();
            cbx_Protocol.Text = "";
           /* chk_Enable.Checked = false;*/
            _currentDeviceId = null;
        }
      
    }
}
