using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SectSystem.Data;

namespace SectSystem
{
    public partial class AddSectForm : Form
    {
        public static bool isOpen;
        public AddSectForm()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            int sex = 0;
            if(sectName.Text=="")
            {
                MessageBox.Show("宗教名字不得为空");
                return;
            }
            if (int.TryParse(years.Text, out int yearNum))
            {
                if (yearNum < 0)
                {
                    MessageBox.Show("学年不得小于0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("学年需为正整数");
                return;
            }
            if (responTxt.Text=="")
            {
                MessageBox.Show("宗派职责未选择");
                return;
            }
            if (tution.Text == "")
            {
                MessageBox.Show("宗派主修课程未选择");
                return;
            }
            if (leaderName.Text == "")
            {
                MessageBox.Show("宗主名字不得为空");
                return;
            }
            if (!int.TryParse(oldBox.Text, out int leaderYear))
            {
                MessageBox.Show("年龄需为整数");
                return;
            }
            if (ractionListBox.Text == "")
            {
                MessageBox.Show("宗主种族不得为空");
                return;
            }
            if (cultivationBox.Text == "")
            {
                MessageBox.Show("宗主修为不得为空");
                return;
            }
            if (!male.Checked && !female.Checked)
            {
                MessageBox.Show("宗主性别不得为空");
                return;
            }
            if(male.Checked)
            {
                sex = 1;
            }
            else
            {
                sex = 1;
            }
            List<string> tutionsList = new List<string>();
            foreach (var item in tution.SelectedItems)
            {
                tutionsList.Add(item.ToString());
            }
            string tutionsJson = JsonConvert.SerializeObject(tutionsList);
            /*SectData sect = new SectData
            {
                Name = sectName.Text,
                Responsibility = responTxt.Text,
                LeaderName = leaderName.Text,
                Tutions = tutionsJson,
                Years = yearNum
            };
            MsgAddPra msgAddPra = new MsgAddPra()
{
    Name = leaderName.Text,
    Years = leaderYear,
    Raction = ractionListBox.Text,
    Cultivation = cultivationBox.Text,
    Sex = sex,
    Sect = sectName.Text,
    Weapon = weaponTxt.Text
};*/
            MsgAddSect msgAddSect = new MsgAddSect()
            {
                name = sectName.Text,
                responsibility = responTxt.Text,
                leaderName = leaderName.Text,
                tutions = tutionsJson,
                years = yearNum
            };
            MsgAddPra msgAddPra = new MsgAddPra()
            {
                name = leaderName.Text,
                years = leaderYear,
                raction = ractionListBox.Text,
                cultivation = cultivationBox.Text,
                sex = sex,
                sect = sectName.Text,
                weapon = weaponTxt.Text
            };
            NetManager.Send(msgAddSect);
            NetManager.Send(msgAddPra);
            EventCenter.Instance.Trigger(StringResource.updateFromDataBase);
        }
        private void years_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void resertBtn_Click(object sender, EventArgs e)
        {
            foreach(var ui in sectGroup.Controls)
            {
                if(ui is TextBox)
                {
                    TextBox textBox = (TextBox)ui;
                    textBox.Text = "";
                }
                if(ui is ListBox)
                {
                    ListBox listBox = (ListBox)ui;
                    listBox.SelectedItems.Clear();
                }
            }
            foreach(var ui in leaderGroup.Controls)
            {
                if (ui is TextBox)
                {
                    TextBox textBox = (TextBox)ui;
                    textBox.Text = "";
                }
                if (ui is ListBox)
                {
                    ListBox listBox = (ListBox)ui;
                    listBox.SelectedItems.Clear();
                }
                if(ui is RadioButton)
                {
                    RadioButton radio = (RadioButton)ui;
                    radio.Checked = false;
                }
                if(ui is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)ui;
                    richTextBox.Text = "无";
                }
            }
        }
        private void oldBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AddSectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NetManager.RemoveListenear("MsgAddPra", OnMsgAddPra);
            NetManager.RemoveListenear("MsgAddSect", OnMsgAddSect);
            isOpen = false;
        }
        private void AddSectForm_Load(object sender, EventArgs e)
        {
            NetManager.AddMsgListener("MsgAddPra", OnMsgAddPra);
            NetManager.AddMsgListener("MsgAddSect", OnMsgAddSect);
            isOpen = true;
        }
        private void OnMsgAddSect(MsgBase msgBase)
        {
            MessageBox.Show("添加宗派成功");
            EventCenter.Instance.Trigger(StringResource.updateFromDataBase);
        }
        private void OnMsgAddPra(MsgBase msgBase)
        {
            MessageBox.Show("添加宗主成功");
            EventCenter.Instance.Trigger(StringResource.updateFromDataBase);
        }
    }
}
