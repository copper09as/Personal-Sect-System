using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectSystem
{
    public partial class ViewSectForm : Form
    {
        public static bool isOpen;
        public ViewSectForm()
        {
            InitializeComponent();
        }
        private void DataUpdate()
        {
            var sects = DbManager.GetSectData();
            listView.Items.Clear();
            foreach(var item in sects)
            {
                ListViewItem it = new ListViewItem();
                it.Text = item.Id.ToString();
                it.SubItems.Add(item.Name);
                it.SubItems.Add(item.LeaderName);
                it.SubItems.Add(item.Man.ToString());
                it.SubItems.Add(item.Woman.ToString());
                it.SubItems.Add(item.Years.ToString());
                it.SubItems.Add(item.Responsibility);
                it.SubItems.Add(item.Tutions);
                listView.Items.Add(it);
            }
        }
        private void ViewSectForm_Load(object sender, EventArgs e)
        {
            NetManager.AddMsgListener("MsgDel", OnMsgDel);
            EventCenter.Instance.Subscribe(StringResource.updateFromDataBase, DataUpdate);
            listView.Columns.Add("id", 120);
            listView.Columns.Add("宗派名字", 120);
            listView.Columns.Add("掌门名字", 120);
            listView.Columns.Add("男修炼者数量", 120);
            listView.Columns.Add("女修炼者数量", 120);
            listView.Columns.Add("修行时长", 120);
            listView.Columns.Add("门派职责", 120);
            listView.Columns.Add("门派课程", 1000);
            DataUpdate();
            isOpen = true;
        }
        private void ViewSectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NetManager.RemoveListenear("MsgDel", OnMsgDel);
            EventCenter.Instance.Unsubscribe(StringResource.updateFromDataBase, DataUpdate);
            isOpen = false;
        }
        private void OnMsgDel(MsgBase msgBase)
        {
            MessageBox.Show("删除成功"); 
            DataUpdate();
        }
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
    }
}
