using MultiSerVIsion.Solution.Presentation.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiSerVIsion
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, BaseViewUc> _viewCache = new Dictionary<string, BaseViewUc>();
        private BaseViewUc _lastActiveView;

        private const int DatailPanelWidth = 300;
        private DeviceTreeUC _treeUC;
        private DeviceDateilUC _detailUC;

        public Form1()
        {
            InitializeComponent();
            InitLayoutSplit();
            InitDeviceTree();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer2.Panel1.Controls.Add(tabControl1);
            var firstTap = tabControl1.SelectedTab;
            CreateViewIfNotExist(firstTap);
            SwitchTabView(firstTap);
        }
        private void InitLayoutSplit()
        {
            split_outer.FixedPanel = FixedPanel.Panel1;
            split_outer.Panel1MinSize = 180;
            split_outer.SplitterDistance = 220;

            split_inter.Dock = DockStyle.Fill;
            split_inter.FixedPanel = FixedPanel.None;
            split_inter.SplitterDistance = split_inter.Width - DatailPanelWidth;

            split_inter.SplitterDistance = split_inter.Width;

            tabControl1.Dock = DockStyle.Fill;
            split_inter.Panel1.Controls.Add(tabControl1);
        }
        private void InitDeviceTree()
        {
            _treeUC = new DeviceTreeUC();
            _treeUC.Dock = DockStyle.Fill;
            split_outer.Panel1.Controls.Add( _treeUC );
            _treeUC.SetUIPlaceholder();
            _treeUC.OnViewShow();

            _treeUC.DeviceNodeSelected += OnDeviceNodeSelected;
            _treeUC.DeviceNodeUnSelect += OndeviceNodeUnSelect;
            _treeUC.AddDeviceRequest += OnAddDeviceRequest;
            _treeUC.RemoveDeviceRequest += OnRemoveDeviceRequest;
            _treeUC.CopyDeviceRequest += OnCopyDeviceRequest;
            _treeUC.ToggleDeviceEnableRequest += OnToggleDeviceEnableRequest;

            _treeUC.OnViewShow();
        }
        private void OnDeviceNodeSelected(string deviceId)
        {
            if (_detailUC == null)
            {
                _detailUC= new DeviceDateilUC();
                _detailUC.Dock= DockStyle.Fill;
                split_inter.Panel2.Controls.Add( _detailUC );
                _detailUC.OnDeviceConfigSave += OnDeviceConfigSaved;
            }
            split_inter.SplitterDistance = split_inter.Width - DatailPanelWidth;
            
        }
        private void OnAddDeviceRequest()
        {

          /*  var newDevice = DeviceSerive.CreateNewDevice();
            if( newDevice != null )
            {
                _treeUC.AddTreeNode("Group_Camera",newDevice.Id,newDevice.Name);
            }*/
        }
        private void OnRemoveDeviceRequest(string deviceId)
        {
          /*  DeviceService.DeleteDevice(deviceId);
            _treeUC.RemoveTreeNode(deviceId);
            split_inter.SplitterDistance = split_inter.Width;*/
        }
        private void OnDeviceConfigSaved(string  deviceId,Dictionary<string,string> config)
        {
       /*     DeviceSerive.SaveDeviceConfig(deviceId, config);
            var dev=DeviceService.GetDevice(deviceId);
            _treeUC.RefreshDeviceStatuesIcon();*/
        }
        private void OnCopyDeviceRequest(string sourceDevId)
        {
           
        }
        private void OnToggleDeviceEnableRequest(string deviceId)
        {

        }
        private void OndeviceNodeUnSelect()
        {
            if (_detailUC != null)
            {
                _detailUC.SetUIPlaceholder();
            }
            split_inter.SplitterDistance = split_inter.Width; 
        }

        private void CreateViewIfNotExist(TabPage targetTab)
        {
            string tabKey = targetTab.Name;
            if (_viewCache.ContainsKey(tabKey)) return;

            BaseViewUc view = null;
            switch (tabKey)
            {
                case "tabPageMonitor":
                    view = new UCMonitorView();
                    break;
                case "tabPageVision":
                    view=new UCVisionView();
                    var vision=view as UCVisionView;
                    vision.ExposureValueChanged += Vision_ExposureChanged;
                    break;

            }
            if(view==null) return;
            view.Dock = DockStyle.Fill;
            view.Visible = false;
            targetTab.Controls.Add(view);
            _viewCache.Add(tabKey, view);
        }
        private void SwitchTabView(TabPage targetTab)
        {
            if(targetTab==null)
                return;
            string tabKey = targetTab.Name;

            CreateViewIfNotExist(targetTab);
            if (!_viewCache.TryGetValue(tabKey, out BaseViewUc currView))
                return;

            if(_lastActiveView!=null&& _lastActiveView != currView)
            {
                _lastActiveView.OnViewHide();
                _lastActiveView.Visible = false;
            }

            currView.Visible = true;
            currView.OnViewHide();

            _lastActiveView = currView;

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
             var tabCtrl=sender as TabControl;
             SwitchTabView(tabCtrl.SelectedTab);
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            TabControl tab=sender as TabControl;
            if (tab == null) return;
           
            Point pt = e.Location;
            int clickIdx = -1; 
            for (int i = 0; i < tab.TabCount; i++)
            {
                Rectangle rect = tab.GetTabRect(i);
                if (rect.Contains(pt))
                {
                    clickIdx = i;
                    break;
                }
            }
            TabPage clickTab=tab.TabPages[clickIdx];
            if (clickTab== tab.SelectedTab)
            {
                SwitchTabView(clickTab);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var uc in _viewCache.Values)
            {
                uc.Dispose();
            }
            _treeUC.Dispose();
            _viewCache.Clear();
            _detailUC?.Dispose();
        }
        private void Vision_ExposureChanged(object sender, EventArgs e)
        {
            var vision = sender as UCVisionView;
        }
    }
}
