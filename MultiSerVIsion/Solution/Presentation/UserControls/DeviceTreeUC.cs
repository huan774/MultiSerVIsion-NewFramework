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
        public event Action AddDeviceRequest;
        public event Action<string> RemoveDeviceRequst;
        public DeviceTreeUC()
        {
            InitializeComponent();
            treeView_Device.NodeMouseClick += TreeView_Device_NodeMouseClick;
            btn_AddDevice.Click += (s, e) => AddDeviceRequest?.Invoke();
            btn_DelDevice.Click += Btn_DelDevice_Click;

            treeView_Device.ContextMenuStrip = contextMenuStrip_Device;
            /*treeView_Device.NodeMouseClick -= TreeView_Device_NodeMouseClick;*/
            tsmiDel.Click += Tsmi_Delete_Click;
            
        }
        private void TreeView_Device_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Tag is string deviceId)
            {
                DeviceNodeSelected?.Invoke(deviceId);
            }
        }
        private void Btn_DelDevice_Click(object sender, EventArgs e)
        {
            if (treeView_Device.SelectedNode?.Tag is string deviceId)
            {
                RemoveDeviceRequst?.Invoke(deviceId);
            }
        }
        private void Tsmi_Delete_Click(object sender,EventArgs e)
        {
            Btn_DelDevice_Click(sender, e);
        }

        public void AddTreeNode(string parentKey,string deviceId,string text)
        {
            var parent=FindNode(treeView_Device.Nodes,parentKey);
            var newNode = new TreeNode(text){ Tag = deviceId  };
            parent?.Nodes.Add(newNode);
            treeView_Device.ExpandAll();
        }
        public void EemoveTreeNode(string deviceid)
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
        private void RefreshDeviceStatusIcon() { }
     
    }
}
