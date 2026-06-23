using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Diagnostics;
using System.Windows.Forms;
using static MultiSerVIsion.Solution.Presentation.UserControls.BaseViewUc;

namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    public partial class UCMonitorView : BaseViewUc
    {
        public event EventHandler BtnStartClick;
        public event EventHandler BtnStopClick;
        public event EventHandler BtnResetClick;
        public event EventHandler BtnPauseClick;
        public event EventHandler BtnClearCountClick;

        public UCMonitorView()
        {
            InitializeComponent();
            Initialize();
            btnStart.Click += (s, e) => BtnStartClick?.Invoke(this, EventArgs.Empty);
            btnStop.Click += (s, e) => BtnStopClick?.Invoke(this, EventArgs.Empty);
            btnPause.Click += (s, e) => BtnPauseClick?.Invoke(this, EventArgs.Empty);
            btnReset.Click += (s, e) => BtnResetClick?.Invoke(this, EventArgs.Empty);
            btnClearCount.Click += (s, e) => BtnClearCountClick?.Invoke(this, EventArgs.Empty);
        }
        private void Initialize()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.Font = new Font("微软雅黑", 9);
                }
            }
        }

        public override void OnViewShow()
        {
            base.OnViewShow();
            lblRunStaus.Text = "待机";
        }
        public override void SetUIPlaceholder()
        {
            txtTotalCount.Text = "0";
            txtOkCount.Text = "0";
            txtNgTxt.Text = "0";
            txtCoodRate.Text = "0.00%";
            lblCamState.Text = "离线";
            lblPlvState.Text = "断开";
            lblLIghtState.Text = "异常";
        }
        public string RunStatusText
        {
            get => lblRunStaus.Text;
            set
            {
                lblRunStaus.Text = value;
                switch (value)
                {
                    case "运行": lblRunStaus.ForeColor = Color.Green; break;
                    case "报警": lblRunStaus.ForeColor = Color.Red; break;
                    default: lblRunStaus.ForeColor = Color.Gray; break;
                }
            }
        }
        public string TotalCount { set=>txtTotalCount.Text = value; }
        public string OKCount { set =>txtOkCount.Text = value; }
        public string NgCount {  set => txtNgTxt.Text = value;}
        public string GoodRate {set =>txtCoodRate.Text = value; }


        public string CameraState { set=>lblCamState.Text = value; }
        public string PlcState { set => lblPlvState.Text = value; }
        public  string LightState { set=>lblLIghtState.Text= value; }

    }
}
