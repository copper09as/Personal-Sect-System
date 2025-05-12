using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SectSystem.Data;

namespace SectSystem
{
    public partial class ViewSectForm : Form
    {
        public static bool isOpen;//窗口是否关闭
        public ViewSectForm()
        {
            InitializeComponent();
        }
        #region 发送刷新ui协议
        private void DataUpdate()
        {
            listView.Items.Clear();
            NetManager.Send(new MsgGetSect());
        }
        #endregion
        #region 注册与注销事件
        private void AddListener()
        {
            NetManager.AddMsgListener(StringResource.msgDel, OnMsgDel);
            NetManager.AddMsgListener(StringResource.msgGetSect, OnMsgGetSect);
            EventCenter.Instance.Subscribe(StringResource.updateFromDataBase, DataUpdate);
        }
        private void RemoveListener()
        {
            NetManager.RemoveListenear(StringResource.msgDel, OnMsgDel);
            NetManager.RemoveListenear(StringResource.msgGetSect, OnMsgGetSect);
            EventCenter.Instance.Unsubscribe(StringResource.updateFromDataBase, DataUpdate);
        }
        #endregion
        #region 建造表格列
        private void CreateColumns()
        {
            listView.Columns.Add("id", 120);
            listView.Columns.Add("宗派名字", 120);
            listView.Columns.Add("掌门名字", 120);
            listView.Columns.Add("男修炼者数量", 120);
            listView.Columns.Add("女修炼者数量", 120);
            listView.Columns.Add("修行时长", 120);
            listView.Columns.Add("门派职责", 120);
            listView.Columns.Add("门派课程", 1000);
        }
        #endregion
        #region 窗口加载与关闭
        private void ViewSectForm_Load(object sender, EventArgs e)
        {
            AddListener();
            CreateColumns();
            DataUpdate();
            isOpen = true;
        }
        private void ViewSectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemoveListener();
            isOpen = false;
        }
        #endregion
        #region 接收数据
        private void OnMsgGetSect(MsgBase msgBase)
        {
            MsgGetSect msg = (MsgGetSect)msgBase;
            var sects = msg.sects;
            listView.Items.Clear();
            foreach (var item in sects)
            {
                ListViewItem it = new ListViewItem();
                it.Text = item.id.ToString();
                it.SubItems.Add(item.name);
                it.SubItems.Add(item.leaderName);
                it.SubItems.Add(item.man.ToString());
                it.SubItems.Add(item.woman.ToString());
                it.SubItems.Add(item.years.ToString());
                it.SubItems.Add(item.responsibility);
                it.SubItems.Add(item.tutions);
                listView.Items.Add(it);
            }
        }
        #endregion
        #region 删除数据显示
        private void OnMsgDel(MsgBase msgBase)
        {
            MessageBox.Show("删除成功"); 
            DataUpdate();
        }
        #endregion
        #region 删除数据按钮
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ChangeSectForm.isOpen)
            {
                MessageBox.Show("修改宗派信息窗口未关闭");
                return;
            }
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中门派");
                return;
            }
           
            DialogResult result = MessageBox.Show(
                "是否要继续删除！",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.OK)
            {
                MsgDel msgDel = new MsgDel()
                {
                    id = listView.SelectedItems[0].Text,
                    table = StringResource.sectTable
                };
                NetManager.Send(msgDel);
            }
            else
            {
                MessageBox.Show("删除已取消。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region 进入修改数据界面
        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (ChangeSectForm.isOpen)
            {
                MessageBox.Show("修改宗派信息窗口未关闭");
                return;
            }
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中门派");
                return;
            }

            ChangeSectForm changeSect = new ChangeSectForm(listView.SelectedItems[0].Text);
            changeSect.MdiParent = this.MdiParent;
            changeSect.Show();
        }
        #endregion
    }
}
