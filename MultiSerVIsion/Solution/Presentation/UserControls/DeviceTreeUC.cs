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
    public partial class DeviceTreeUC : BaseViewUc
    {

        public event Action<string> DeviceNodeSelected;
        public event Action DeviceNodeUnSelect;
        public event Action AddDeviceRequest;
        public event Action<string> RemoveDeviceRequest;
        public event Action<string> CopyDeviceRequest;
        public event Action<string> ToggleDeviceEnableRequest;
        public DeviceTreeUC()
        {
            InitializeComponent();

            treeView_Device.ContextMenuStrip = contextMenuStrip_Device;
            treeView_Device.NodeMouseClick += TreeView_Device_NodeMouseClick;
            
            btn_AddDevice.Click += (s, e) => AddDeviceRequest?.Invoke();
            btn_DelDevice.Click += Btn_DelDevice_Click;
            contextMenuStrip_Device.Opening += ContextMenuStrip_Device_Opening;

           tsmi_AddChild.Click += Tsim_AddChild_Click;
            tsmi_Copy.Click += Tsim_Copy_Click;
            tsmi_EnableDisable.Click += Tsmi_EnableDisable_Click;
            tsmi_Delete.Click += Tsmi_Delete_Click;
            
        }

        private void RaiseDeviceSelected(string device)
        {
            DeviceNodeSelected?.Invoke(device);
        }
        private void RaiseDeviceUnSelect()
        {
            DeviceNodeUnSelect?.Invoke();
        }
        private void RaiseAddDevice()
        {
            AddDeviceRequest?.Invoke();
        }
        private void RaiseRemoveDevice(string devId)
        {
            RemoveDeviceRequest?.Invoke(devId);
        }
        private void RaiseCopyDevice(string devId)
        {
            CopyDeviceRequest?.Invoke(devId);
        }
        private void RaiseToggleEnable(string devId)
        {
            ToggleDeviceEnableRequest?.Invoke(devId);
        }
        private void TreeView_Device_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           if(e.Button!=MouseButtons.Left) return;
            var node = e.Node;
            if(node.Tag==null||string.IsNullOrWhiteSpace(node.Tag.ToString()))
            {
                RaiseDeviceUnSelect();
                return;
            }
            if(node.Tag is string devId)
            {
                RaiseDeviceSelected(devId);
            }
        }
        private void ContextMenuStrip_Device_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var selectNode = treeView_Device.SelectedNode;
            if (selectNode != null)
            {
                e.Cancel = true;
                return;
            }

            bool isDeviceNode=selectNode.Tag!=null&&selectNode.Tag is string deviceNode;

            tsmi_AddChild.Visible = true;
            tsmi_Copy.Visible = isDeviceNode;
            tsmi_EnableDisable.Visible = isDeviceNode;
            tsmi_Delete.Visible = isDeviceNode;
        }
        private void Btn_AddDevice_Click(object sender, EventArgs e)
        {
            RaiseAddDevice();
        }
        private void Btn_DelDevice_Click(object sender, EventArgs e)
        {
            if (treeView_Device.SelectedNode?.Tag is string deviceId)
            {
                RemoveDeviceRequest?.Invoke(deviceId);
            }
        }
        private void Tsim_AddChild_Click(object sender, EventArgs e)
        {
            RaiseAddDevice();
        }
        private void Tsim_Copy_Click(object sender, EventArgs e)
        {
            var node = treeView_Device.SelectedNode;
            if(node?.Tag is string deviceId)
            {
                RaiseCopyDevice(deviceId);
            }
        }
        private void Tsmi_EnableDisable_Click(object sender, EventArgs e)
        {
            var node = treeView_Device.SelectedNode;
            if(node?.Tag is string deviceId)
            {
                RaiseToggleEnable(deviceId);
            }
        }
        private void Tsmi_Delete_Click(object sender,EventArgs e)
        {
           var node=treeView_Device.SelectedNode;
            if( node?.Tag is string deviceId)
            {
                RaiseRemoveDevice(deviceId);
            }
        }

        public void AddTreeNode(string parentKey,string deviceId,string text)
        {
            var parent=FindNode(treeView_Device.Nodes,parentKey);
            var newNode = new TreeNode(text){ Tag = deviceId  };
            parent?.Nodes.Add(newNode);
            treeView_Device.ExpandAll();
        }
        public void RemoveTreeNode(string deviceid)
        {
            var node = FindNode(treeView_Device.Nodes, deviceid);
            node?.Remove();
        }
        private TreeNode FindNode(TreeNodeCollection nodes, string tag)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag?.ToString() == tag) return node;
                var child = FindNode(node.Nodes, tag);
                if (child != null) return child;
            }
            return null;
        }
        public override void OnViewShow()
        {
            base.OnViewShow();
            RefreshDeviceStatusIcon();

        }
        public override void SetUIPlaceholder()
        {
            treeView_Device.Nodes.Clear();
            treeView_Device.Nodes.Add("相机分组").Tag = "Group_Camera";
            treeView_Device.Nodes.Add("运动轴分组").Tag = "Group_Motion";
            treeView_Device.Nodes.Add("PLC分组").Tag = "Group_PLCser";
        }
        public void ClearSelectNode()
        {
            treeView_Device.SelectedNode = null;
            RaiseDeviceUnSelect();
        }
        private void RefreshDeviceStatusIcon() { }
     
    }
}
