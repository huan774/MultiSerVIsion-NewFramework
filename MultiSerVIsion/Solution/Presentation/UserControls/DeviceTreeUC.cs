using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    public partial class DeviceTreeUC : BaseViewUc
    {
        private TreeNode _rightClickGroupNode;
        private TreeNode _rightClickNode=null;
        private Func<string, bool> GetDeviceEnableStatus {  get; set; }

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
            contextMenuStrip_Device.Opening += ContextMenuStrip_Device_Opening;
            contextMenuStrip_Device.Closed += (s, e) => _rightClickNode = null;

            btn_AddDevice.Click += Btn_AddDevice_Click;
            btn_DelDevice.Click += Btn_DelDevice_Click;
            
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
            if (e.Button == MouseButtons.Left)
            {
                _rightClickNode = null;
                _rightClickGroupNode= null;

                string nodeTage=e.Node.Tag?.ToString();
                if (nodeTage != null && !nodeTage.StartsWith("Group_"))
                {
                    RaiseDeviceUnSelect();
                }
                else if (!string.IsNullOrEmpty(nodeTage))
                {
                    RaiseDeviceSelected(nodeTage);
                    _rightClickGroupNode = e.Node.Parent;
                    _rightClickNode = e.Node;
                }
                else
                {
                    RaiseDeviceUnSelect();
                }
            } 
            else if(e.Button == MouseButtons.Right)
            {
                string tag = e.Node.Tag?.ToString() ?? "";
                if (tag.StartsWith("Group_"))
                {
                    _rightClickGroupNode=e.Node;
                    _rightClickNode=null;
                }
                else
                {
                    _rightClickNode = e.Node;
                    _rightClickGroupNode = e.Node.Parent;
                    
                }
            }
        }
        private void ContextMenuStrip_Device_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var rightNode = _rightClickNode;
            var groupNode = _rightClickGroupNode;

            if (rightNode == null && groupNode==null)
            {
                e.Cancel = true;
                return;
            }

            bool isDeviceNode = rightNode!= null;

            tsmi_AddChild.Visible = true;

            tsmi_Copy.Visible = isDeviceNode;
            tsmi_EnableDisable.Visible = isDeviceNode;
            tsmi_Delete.Visible = isDeviceNode;

            if (isDeviceNode && GetDeviceEnableStatus != null)
            {
                string devId = rightNode.Tag.ToString();
                bool enable=GetDeviceEnableStatus(devId);
                tsmi_EnableDisable.Text = enable ? "禁用设备" : "启动设备";
            }
        }
        private void Btn_AddDevice_Click(object sender, EventArgs e)
        {
            RaiseAddDevice();
        }
        private void Btn_DelDevice_Click(object sender, EventArgs e)
        {
            if (treeView_Device.SelectedNode?.Tag is string deviceId)
            {
                RaiseRemoveDevice(deviceId);
            }
        }
        private void Tsim_AddChild_Click(object sender, EventArgs e)
        {
           
            RaiseAddDevice();
            
        }
        private void Tsim_Copy_Click(object sender, EventArgs e)
        {
            var node = _rightClickNode;
            if (node?.Tag is string deviceId)
            {
                RaiseCopyDevice(deviceId);
            }
        }
        private void Tsmi_EnableDisable_Click(object sender, EventArgs e)
        {
            var node = _rightClickNode;
            if(node?.Tag is string deviceId)
            {
                RaiseToggleEnable(deviceId);
            }
        }
        private void Tsmi_Delete_Click(object sender,EventArgs e)
        {
           var node=_rightClickNode;
            if( node?.Tag is string deviceId)
            {
                RaiseRemoveDevice(deviceId);
            }
        }
        public void AddTreeNode(string parentKey,string deviceId,string text)
        {

            TreeNode targetGroup = null;
            foreach (TreeNode rootNode in treeView_Device.Nodes)
            {
                if (rootNode.Tag?.ToString() == parentKey)
                {
                    targetGroup = rootNode;
                    break;
                }
            }if (targetGroup == null) return;

            TreeNode devNode = new TreeNode(deviceId);
            devNode.Tag = deviceId;
            targetGroup.Nodes.Add(devNode);
            targetGroup.Expand();
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
        public string GetRightClickGroupKey()
        {
            MessageBox.Show("reture");
            return _rightClickGroupNode?.Tag?.ToString() ?? string.Empty;
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
            _rightClickNode= null;
            RaiseDeviceUnSelect();
        }
        private void RefreshDeviceStatusIcon() { }
    }
}
